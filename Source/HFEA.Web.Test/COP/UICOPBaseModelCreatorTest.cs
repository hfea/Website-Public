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
    public class UICOPBaseModelCreatorTest
    {
        private const string ExtraLinkTitle = "Regulatory principles";
        private const string ExtraLinkUrl = "/reg-principles";
        private const string CopUrl = "/code-of-practice";
        private const string ActiveSectionId = "2";

        private ICOPReaderClient readerClientFake;
        private ICOPUrlResolver linkResolverFake;

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsNullExceptionIfApiClientIsNull()
        {
            var modelCreator = new BaseCOPModelCreator(null, linkResolverFake);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsNullExceptionIfLinkResolverIsNull()
        {
            var modelCreator = new BaseCOPModelCreator(readerClientFake, null);
        }

        [TestMethod]
        public void ModelCreatorInstantiatesIfApiClientIsNotNull()
        {
            Mock<ICOPReaderClient> clientMock = new Mock<ICOPReaderClient>();
            var modelCreator = new BaseCOPModelCreator(clientMock.Object, this.linkResolverFake);
            Assert.IsNotNull(modelCreator);
        }
        
        [TestMethod]
        public void CopNavigationContainsAllExistingGroupsIfNoActiveSectionSelected()
        {
            var modelCreator = new BaseCOPModelCreator(this.readerClientFake, this.linkResolverFake);

            var nav = modelCreator.GetNavigation();
            Assert.IsNotNull(nav);

            var modelGroups = nav.GroupList.Select(x => x.GroupName).ToList();

            Assert.IsTrue(modelGroups.Count == Data.Groups.Data.COPGroups.Count());
            var rawDataGroupNames = Data.Groups.Data.COPGroups.Select(x => x.GroupName).ToList();
            Assert.IsTrue(modelGroups.All(x => rawDataGroupNames.Contains(x)));

        }

        [TestMethod]
        public void CopNavigationContainsAllExistingGroupsIfActiveGroupSelected()
        {
            Assert.IsNotNull(this.readerClientFake);
            var modelCreator = new COPModelCreator(this.readerClientFake, this.linkResolverFake);

            var viewModel = modelCreator.GetViewModel(ActiveSectionId);
            Assert.IsNotNull(viewModel);

            var modelGroups = viewModel.Navigation.GroupList.Select(x => x.GroupName).ToList();

            Assert.IsTrue(modelGroups.Count == Data.Groups.Data.COPGroups.Count());
            var rawDataGroupNames = Data.Groups.Data.COPGroups.Select(x => x.GroupName).ToList();
            Assert.IsTrue(modelGroups.All(x => rawDataGroupNames.Contains(x)));
        }

        [TestMethod]
        public void CopNavigation_OnlyActiveGroupIsMarkedAsActive()
        {
            Assert.IsNotNull(this.readerClientFake);
            var modelCreator = new COPModelCreator(this.readerClientFake, this.linkResolverFake);

            var viewModel = modelCreator.GetViewModel(ActiveSectionId);

            var rawActiveGroup = this.GetRawGroupBySectionId(ActiveSectionId).GroupName;

            var activeGroups = viewModel.Navigation.GroupList.Where(x => x.IsActive).ToList();

            Assert.IsNotNull(activeGroups);
            Assert.IsTrue(activeGroups.Count == 1);
            Assert.IsTrue(activeGroups.First().GroupName == rawActiveGroup);
        }

        [TestMethod]
        public void CopNavigation_ActiveGroupHasSubItems()
        {
            var modelCreator = new COPModelCreator(this.readerClientFake, linkResolverFake);

            var viewModel = modelCreator.GetViewModel(ActiveSectionId);
            var activeGroup = viewModel.Navigation.GroupList.First(x => x.IsActive);

            Assert.IsTrue(activeGroup.SectionItemList.Any());
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
            urlResolver
                .Setup(x => x.GetSectionLink(It.IsAny<int>()))
                .Returns<int>((id) => { return CopUrl + id.ToString(); });
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
