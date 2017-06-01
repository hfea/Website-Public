using HFEA.BL.ModelCreators;
using HFEA.Connector.Contracts.Clients.COP;
using HFEA.Web.ViewModel.COP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HFEA.Web.Test.COP
{
    [TestClass]
    public class UICOPModelCreatorTest
    {
        private const string ActiveSectionId = "2";
        private const string RegPrinciplesLink = "/reg-principles";

        private ICOPReaderClient readerClientFake;
        private ICOPUrlResolver linkResolverFake;
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsNullExceptionIfApiClientIsNull()
        {
            var modelCreator = new COPModelCreator(null, linkResolverFake);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsNullExceptionIfLinkResolverIsNull()
        {
            var modelCreator = new COPModelCreator(readerClientFake, null);
        }

        [TestMethod]
        public void GetApiClientInheritsBaseApiClient()
        {
            // Testing of functionality of BaseCOPModelCreator is covered
            // in UICOPBaseModelCreatorTest
            // if this test ever fails, then a developer must double check
            // whether viewModel is created successfully. 
            var modelCreator = new COPModelCreator(readerClientFake, linkResolverFake);
            Assert.IsInstanceOfType(modelCreator, typeof(BaseCOPModelCreator));
        }

        /// <summary>
        /// This is a very basic test which only checks/validates list sizes
        /// </summary>
        [TestMethod]
        public void ActiveSectionIsNotNull()
        {   
            Assert.IsNotNull(this.readerClientFake);
            var modelCreator = new COPModelCreator(this.readerClientFake, this.linkResolverFake);

            var viewModel = modelCreator.GetViewModel(ActiveSectionId);

            var activeSection = viewModel.ActiveSection;

            Assert.IsNotNull(activeSection);
            Assert.IsTrue(activeSection.SectionNumber == ActiveSectionId);
        }

        [TestMethod]
        public void SubSubSubActIsMapped()
        {
            var modelCreator = new COPModelCreator(this.readerClientFake, this.linkResolverFake);
            
            var viewModel = modelCreator.GetViewModel(ActiveSectionId);

            var section = viewModel.ActiveSection;

            Assert.IsTrue(section.ActList.Any());
            Assert.IsTrue(section.ActList[0].ItemList.Any());
            Assert.IsTrue(section.ActList[0].ItemList[0].ItemList.Any());

            var sub3section = section.ActList[0].ItemList[0].ItemList[0];
            Assert.IsTrue(sub3section.SectionNumber == "1");
        }

        [TestMethod]
        public void FileListHasAttachedFiles()
        {
            var modelCreator = new COPModelCreator(this.readerClientFake, this.linkResolverFake);

            var viewModel = modelCreator.GetViewModel(ActiveSectionId);

            var rawData = Data.Section.Data;
            var files = new List<Connector.Contracts.COP.COPFile>();
            files.Add(rawData.COPDocument);
            files.Add(rawData.COPSections[0].COPDocument);

            var fileList = viewModel.ActiveSection.FileList;
            Assert.IsNotNull(fileList);
            Assert.IsTrue(viewModel.HasFilesList);
            Assert.IsTrue(fileList.Count == files.Count);
            Assert.IsTrue(files.All(x => files.Any(a => a.Url == x.Url)));
        }             

        [TestInitialize]
        public void InitClient()
        {
            BL.AutoMapperInit.Init();
            Mock<ICOPReaderClient> clientMock = new Mock<ICOPReaderClient>();
            clientMock
                .Setup(x => x.GetAllGroups())
                .Returns(Data.Groups.Data);

            clientMock
                .Setup(x => x.GetSection(It.IsAny<int>()))
                .Returns<int>((x) =>
                {
                    return Data.Section.Data; 
                });

            this.readerClientFake = clientMock.Object;

            Mock<ICOPUrlResolver> urlResolver = new Mock<ICOPUrlResolver>();
            this.linkResolverFake = urlResolver.Object;     
        }

        private Connector.Contracts.COP.COPGroup GetRawGroupBySectionId(string sectionId)
        {
            var gr = Data.Groups.Data.COPGroups
                .Where(x => x.COPSections.Any(z => z.SectionNumber == sectionId))
                .FirstOrDefault();

            return gr;
        }
    }
}
