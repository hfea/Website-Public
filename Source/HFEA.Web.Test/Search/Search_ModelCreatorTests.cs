using HFEA.Connector.Contracts.Clients.AccessControl;
using HFEA.CP.BL.Contracts;
using HFEA.CP.BL.Contracts.Search;
using HFEA.CP.BL.Readers;
using HFEA.CP.Web.ViewModel.Interfaces;
using HFEA.CP.Web.ViewModel.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.CP.BL.Test.Search
{
    [TestClass]
    public class Search_ModelCreatorTests
    {
        private IHfeaSearcher searcher;
        private ITagsReader tagsReader;
        private IReferenceDataUrlResolver urlResolver;

        private SearchParameters searchParameters;
        private SearchViewModelReader modelCreator;

        private List<int> selectedContentTags = new List<int>() { Data.TagsFromApi.Data.First().Id, Data.TagsFromApi.Data.Last().Id };
        private List<int> selectedProductTags = new List<int>() { Data.ProductTags.Data.First().Id, Data.ProductTags.Data.Last().Id };
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsNullExceptionIfNoSearcher()
        {
            var test = new SearchViewModelReader(null, this.tagsReader, this.urlResolver);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsNullExceptionIfNoTagsReader()
        {
            var test = new SearchViewModelReader(this.searcher, null, this.urlResolver);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsNullExceptionIfNoUrlResolver()
        {
            var test = new SearchViewModelReader(this.searcher, this.tagsReader, null);
        }

        [TestMethod]
        public void SearchBoxViewModel_HasData()
        {
            var model = this.modelCreator.GetSearchBoxViewModel(this.searchParameters);

            Assert.IsNotNull(model);
            Assert.IsNotNull(model.SearchParams);
            Assert.IsNotNull(model.SearchParams.ContentTags);
            Assert.IsNotNull(model.SearchParams.ProductFilters);
            Assert.IsTrue(!string.IsNullOrEmpty(model.SearchParams.SearchKeywords));
        }

        [TestMethod]
        public void SearchBoxViewModel_SearchParameters_HaveMappedContentTags()
        {
            var model = this.modelCreator.GetSearchBoxViewModel(this.searchParameters);
            var tags = model.SearchParams.ContentTags;
            var tagsValues = model.SearchParams.ContentTagsValue;

            Assert.AreEqual(tags.Count, this.selectedContentTags.Count);
            Assert.IsTrue(tags.All(x => !string.IsNullOrEmpty(x.Value)));
            Assert.IsTrue(tags.All(x => this.selectedContentTags.Contains(x.Id)));
        }

        [TestMethod]
        public void SearchBoxViewModel_SearchParameters_HaveMappedProductTags()
        {
            var model = this.modelCreator.GetSearchBoxViewModel(this.searchParameters).SearchParams;
            var tags = model.ProductFilters;
            var checkedTagIds = this.searchParameters.ProductFilters
                .Where(x => x.IsChecked).Select(x => x.Id).ToList();

            Assert.AreEqual(tags.Count, Data.ProductTags.Data.Count);
            Assert.IsTrue(tags.All(x => !string.IsNullOrEmpty(x.Value)));
            Assert.IsTrue(tags.All(x => Data.ProductTags.Data.Any(d=>d.Id == x.Id)));
            
            var modelCheckedTags = model.ProductFilters
                .Where(x => x.IsChecked).Select(x => x.Id).ToList();

            Assert.IsTrue(modelCheckedTags.All(x => checkedTagIds.Contains(x)));
        }

        [TestMethod]
        public void SearchBoxViewModel_SearchParameters_HaveSearchKeyword()
        {
            var model = this.modelCreator.GetSearchBoxViewModel(this.searchParameters);
            
            Assert.AreEqual(this.searchParameters.SearchKeywords, model.SearchParams.SearchKeywords);
        }

        [TestInitialize]
        public void Init()
        {
            this.searchParameters = new SearchParameters()
            {
                SearchKeywords = "my test",
                ContentTagsValue = string.Format("{0},{1}", selectedContentTags[0], selectedContentTags[1]),
                ProductFilters = Data.ProductTags.Data.Select(x => new ContentTagValue()
                {
                    Id = x.Id,
                    IsChecked = selectedProductTags.Contains(x.Id)
                }).ToList()
            };
            Mock<IHfeaSearcher> searcherMock = new Mock<IHfeaSearcher>();
            searcherMock.Setup(x => x.Search(It.IsAny<SearchFilters>())).Returns(new List<ISearchResultItem>()); // TODO
            this.searcher = searcherMock.Object;

            Mock<ITagsReader> tagsReaderMock = new Mock<ITagsReader>();
            tagsReaderMock.Setup(x => x.GetContentTagList()).Returns(Data.TagsFromApi.Data);
            tagsReaderMock.Setup(x => x.GetPortalProductTagList()).Returns(Data.ProductTags.Data);
            this.tagsReader = tagsReaderMock.Object;

            Mock<IReferenceDataUrlResolver> urlResolverMock = new Mock<IReferenceDataUrlResolver>();
            urlResolverMock.Setup(x => x.GetCeoLetterUrl(It.IsAny<string>())).Returns("/TODO");
            urlResolverMock.Setup(x => x.GetChairLetterUrl(It.IsAny<string>())).Returns("/TODO");
            urlResolverMock.Setup(x => x.GetCmsUrlByPageId(It.IsAny<int>())).Returns("/TODO");
            urlResolverMock.Setup(x => x.GetCopSectionUrl(It.IsAny<string>())).Returns("/TODO");
            urlResolverMock.Setup(x => x.GetDirectionsUrl()).Returns("/TODO");
            urlResolverMock.Setup(x => x.GetLicenceConditionsResearchUrl()).Returns("/TODO");
            urlResolverMock.Setup(x => x.GetLicenceConditionsTsUrl()).Returns("/TODO");
            this.urlResolver = urlResolverMock.Object;
            
            this.modelCreator = new SearchViewModelReader(this.searcher, this.tagsReader, this.urlResolver);
        }
    }
}
