using HFEA.BL.Contracts.Search;
using HFEA.Web.SearchProvider;
using HFEA.Web.Test.Search.Data;
using HFEA.Web.ViewModel.API;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace HFEA.Web.Test.Search
{
    [TestClass]
    public class Search_UmbracoReaderTests : UmbracoInit.TestBase
    {
        private UmbracoContentReader reader;

        [TestMethod]
        public void SearchSourceReaderReturnSomeResults()
        {
            List<ISearchIndexItem> data = this.reader.GetValidUmbracoNodeData();

            Assert.IsNotNull(data);
            Assert.IsTrue(data.Count > 0);
        }

        [TestInitialize]
        public override void Init()
        {
            Mock<ITagsApiModelCreator> tagsReaderMock = new Mock<ITagsApiModelCreator>();
            tagsReaderMock.Setup(x => x.GetTagList()).Returns(Tags.Data);
        
            base.Init();
            this.reader = new UmbracoContentReader(tagsReaderMock.Object);
        }
    }
}
