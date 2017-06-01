using HFEA.BL.Contracts.Search;
using HFEA.BL.SearchProvider.DataSources;
using HFEA.Connector.Contracts.Clients.AccessControl;
using HFEA.Connector.Contracts.Clients.COP;
using HFEA.Connector.Contracts.COP;
using HFEA.Web.Test.Search.Data;
using HFEA.Web.ViewModel.COP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using SearchSource = HFEA.BL.Contracts.Constants.Search.SearchSource;

namespace HFEA.Web.Test.Search
{
    [TestClass]
    public class Search_CopSourceTests
    {
        private int[] SectionIds = new int[] { 1, 3 };
        private const string BaseUrl = "/cop/";

        private ICOPReaderClient copDataReader;
        private ICOPUrlResolver urlResolver;
        private ITagsReader tagsReader;

        private ISearchDataSource reader;
        private List<COPItem> rawSections;

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsNullExceptionIfNoDataReader()
        {
            var test = new CopSource(null, urlResolver, tagsReader);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsNullExceptionIfNoUrlResolver()
        {
            var test = new CopSource(copDataReader, null, tagsReader);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsNullExceptionIfNoTagsReader()
        {
            var test = new CopSource(copDataReader, urlResolver, null);
        }

        [TestMethod]
        public void ItemSourceListHasCorrectAmounOfItems()
        {
            List<ISearchIndexItem> data = this.reader.AllItemsList;

            Assert.IsNotNull(data);

            var sections = this.rawSections.SelectMany(x => x.COPSections).ToList();

            Assert.IsTrue(data.Count == sections.Count);
        }

        [TestMethod]
        public void ItemByIdIsReturnedAndNotNull()
        {
            ISearchIndexItem data = this.reader.GetItemById(SectionIds[0]);

            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void SearchIndexItemMappedCorrectlyAtLeastForOneItem()
        {
            int testId = SectionIds[0];
            ISearchIndexItem data = this.reader.GetItemById(testId);

            Assert.IsNotNull(data);

            var raw = this.rawSections.SelectMany(x=>x.COPSections).First(x => x.SectionNumberInt == testId);

            List<string> randomSearchString = new List<string>
            {
                // acts (from various levels)
                "The Authority may on application grant a licence to any person if the requirements of subsection (2) below are met.",
                "The requirements mentioned in subsection (1) above are -",
                "that the application is for a licence designating an individual as the person under whose supervision the activities to be authorised by the licence are to be carried on,",
                "the application is made with the consent of that individual, and",
                "any person designated in the licence, or in a notice given to the Authority by the person who holds the licence or the person responsible, as a person to whom the licence applies, and",
                // licence conditions
                "Where the PR is unable to carry out their duties, whether permanently or temporarily, (eg, where the PR is suspended pending investigation or is on extended sick leave) the holder of the licence must inform the Authority immediately and apply to the Authority for a licence variation to nominate a substitute PR. This nominated substitute PR must not commence their post unless and until the Authority decides that they are suitable.",
                // Guidance (versions data)
                "Appointing the person responsible",
                "Interpretation of mandatory requirements\r\n\r\nThe law requires licensable activity to take place only under the supervision of the ‘person responsible’, as named on the centre’s licence.\r\n\r\nAn individual can be appointed as the person responsible only with the approval of the HFEA. That person must complete the Persons Responsible Entry Programme (PREP) assessment before the HFEA can consider whether or not to approve them."          
            };


            Assert.IsTrue(data.Title == raw.SectionName);
            Assert.IsTrue(randomSearchString.All(x => data.Body.IndexOf(x) > -1));
            Assert.IsTrue(data.SourceType == SearchSource.COP);
            Assert.IsTrue(data.Tags == raw.CommaSeparatedSearchTags);
        }

        [TestInitialize]
        public void Init()
        {
            var groups = CopGroups.Data;
            var apiClientMock = new Mock<ICOPReaderClient>();
            apiClientMock.Setup(x => x.GetAllGroups()).Returns(CopGroups.Data);
            apiClientMock.Setup(x => x.GetSection(It.IsAny<int>())).Returns<int>(x => {
                return CopSection.Data(x);
            });


            var urlHelperMock = new Mock<ICOPUrlResolver>();
            urlHelperMock
                .Setup(x => x.GetSectionLink(It.IsAny<int>()))
                .Returns<int>(x => { return this.GetUrlById(x); });

            var tagsReaderMock = new Mock<ITagsReader>();
            tagsReaderMock
                .Setup(x => x.GetContentTagList())
                .Returns(new List<Connector.Contracts.Api.ContentTag>());

            this.urlResolver = urlHelperMock.Object;
            this.copDataReader = apiClientMock.Object;
            this.tagsReader = tagsReaderMock.Object;

            this.rawSections = new List<COPItem>()
            {
                CopSection.Data(1),
                CopSection.Data(3)
            };

            this.reader = new CopSource(this.copDataReader, this.urlResolver, this.tagsReader);
        }

        private string GetUrlById(int id)
        {
            return BaseUrl + id;
        }
    }
}
