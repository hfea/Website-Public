using HFEA.BL.Contracts;
using HFEA.BL.Readers;
using HFEA.Connector.Contracts.CaFC;
using HFEA.Connector.Contracts.Clients.CaFC;
using HFEA.Connector.Service.Clients.CaFC;
using HFEA.Web.ViewModel.CaFC;
using HFEA.Web.ViewModel.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HFEA.Web.Test.CaFC
{
    [TestClass]
    public class UICaFCModelCreatorTest
    {
        private int[] searchParams = new int[] { 1829, 1830, 1834 }; //, 1835, 2028, 2029, 2032, 2033, 2035, 2046, 2064, 2067, 2068 };
        //private ICaFCSearch cafcSearchClient;
        private ICaFCSearch cafcSearchClientFake;
        private ICafcProfileUrlHelper profileUrlHelper;
        private IJsonSerializer serializer;
        private CaFCSearchModelCreator modelCreator;

        private SearchParameters distanceSearchParams;
        private SearchParameters fullSearchParams;

        private SearchResults distanceSearchResults;
        private SearchResults fullSearchResults;


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsNullExceptionIfSearchClientIsNull()
        {
            Mock<ICaFCSearch> mockClient = new Mock<ICaFCSearch>();
            var modelCreator = new CaFCSearchModelCreator(mockClient.Object, null, this.serializer);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsNullExceptionIfUrlHelperIsNull()
        {
            Mock<ICafcProfileUrlHelper> mockHelper = new Mock<ICafcProfileUrlHelper>();
            var modelCreator = new CaFCSearchModelCreator(null, mockHelper.Object, this.serializer);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsNullExceptionIfSeriazerIsNull()
        {
            Mock<ICafcProfileUrlHelper> mockHelper = new Mock<ICafcProfileUrlHelper>();
            var modelCreator = new CaFCSearchModelCreator(null, mockHelper.Object, null);
        }

        [TestMethod]
        public void ModelCreatorInstantiatesIfConstructorParametersNotNull()
        {
            var modelCreator = new CaFCSearchModelCreator(this.cafcSearchClientFake, this.profileUrlHelper, this.serializer);
            Assert.IsNotNull(modelCreator);
        }

        [TestMethod]
        public void ResultViewModelPaginationDataProcessedCorrectly()
        {
            var returned = modelCreator.GetCaFCResultsViewModel(fullSearchParams);
            
            Assert.IsTrue(returned.PaginationData != null);
            Assert.IsTrue(returned.TotalRecords > 0);
            Assert.IsTrue(returned.PaginationData.TotalPages > 0);
            Assert.IsTrue(returned.PaginationData.PageSize == fullSearchParams.PageSize);
            Assert.IsTrue(returned.PaginationData.Page == fullSearchParams.PageNumber);
        }

        [TestMethod]
        public void FilterViewModelContainsAllSearchOptions()
        {
            SearchFilters allSearchFilters = this.cafcSearchClientFake.GetSearchTerms();

            List<int> allIds = allSearchFilters.CounsellingAndSupport.Select(x => x.Id).ToList();
            allIds.AddRange(allSearchFilters.DonorRecruitment.Select(x => x.Id));
            allIds.AddRange(allSearchFilters.EligibilityAndFunding.Select(x => x.Id));
            //allIds.AddRange(allSearchFilters.NonLicensedTreatmentsAndServices.Select(x => x.Id));
            allIds.AddRange(allSearchFilters.ScreeningServices.Select(x => x.Id));
            allIds.AddRange(allSearchFilters.Treatments.Select(x => x.Id));
            
            var returned = modelCreator.GetCaFCFiltersViewModel(distanceSearchParams);

            var returnedIds = returned.DynamicFilters.SelectMany(x => x.ItemList).Select(x => x.Id).ToList();

            Assert.IsTrue(returned.Location == this.distanceSearchParams.Source);
            Assert.IsTrue(returned.DistanceAsNullableInt == this.distanceSearchParams.Distance);
            Assert.IsTrue(returnedIds.Count == allIds.Count);
            Assert.IsTrue(returnedIds.OrderBy(x => x).SequenceEqual(allIds.OrderBy(x => x)));
        }

        [TestMethod]
        public void SelectedDistanceIsSetInDistanceOptionsList()
        {
            var returned = modelCreator.GetCaFCFiltersViewModel(distanceSearchParams);

            Assert.IsNotNull(returned.DistanceOptionsList);
            Assert.IsTrue(returned.DistanceAsNullableInt == distanceSearchParams.Distance);

            var selected = returned.DistanceOptionsList.Where(x => x.Selected).ToList();
            Assert.IsTrue(selected.Count() == 1);
            Assert.IsTrue(selected[0].Value == distanceSearchParams.Distance.ToString());
        }

        [TestMethod]
        public void SelectedCounsellingANDSupportOptionsMappedToFilterViewModel()
        {
            var filterType = CaFCConstants.DynamicFilterType.CounsellingAndSupport;

            SearchFilters allSearchFilters = this.cafcSearchClientFake.GetSearchTerms();

            List<int> testList = allSearchFilters.CounsellingAndSupport.Select(x => x.Id).OrderBy(x => x).ToList();

            Assert.IsTrue(testList.Any());

            this.CompleteFilterTest(testList, filterType);
        }

        [TestMethod]
        public void SelectedDonorRecruitmentOptionsMappedToFilterViewModel()
        {
            var filterType = CaFCConstants.DynamicFilterType.DonorRecruitment;

            SearchFilters allSearchFilters = this.cafcSearchClientFake.GetSearchTerms();

            List<int> testList = allSearchFilters.DonorRecruitment.Select(x => x.Id).OrderBy(x => x).ToList();

            Assert.IsTrue(testList.Any());

            this.CompleteFilterTest(testList, filterType);
        }

        [TestMethod]
        public void SelectedEligibilityAndFundingOptionsMappedToFilterViewModel()
        {
            var filterType = CaFCConstants.DynamicFilterType.EligibilityAndFunding;

            SearchFilters allSearchFilters = this.cafcSearchClientFake.GetSearchTerms();

            List<int> testList = allSearchFilters.EligibilityAndFunding.Select(x => x.Id).OrderBy(x => x).ToList();

            Assert.IsTrue(testList.Any());

            this.CompleteFilterTest(testList, filterType);
        }

        /// <summary>
        /// On 1/3/2015 API doesn't return NonLicensedTreatmentsAndServices any longer
        /// Test is commented out
        /// </summary>
        //[TestMethod]
        //public void SelectedNonLicensedTreatmentsAndServicesOptionsMappedToFilterViewModel()
        //{
        //    var filterType = CaFCConstants.DynamicFilterType.NonLicensedTreatmentsAndServices;

        //    SearchFilters allSearchFilters = this.cafcSearchClientFake.GetSearchTerms();

        //    List<int> testList = allSearchFilters.NonLicensedTreatmentsAndServices.Select(x => x.Id).OrderBy(x => x).ToList();

        //    Assert.IsTrue(testList.Any());

        //    this.CompleteFilterTest(testList, filterType);
        //}

        [TestMethod]
        public void SelectedScreeningServicesOptionsMappedToFilterViewModel()
        {
            var filterType = CaFCConstants.DynamicFilterType.ScreeningServices;

            SearchFilters allSearchFilters = this.cafcSearchClientFake.GetSearchTerms();

            List<int> testList = allSearchFilters.ScreeningServices.Select(x => x.Id).OrderBy(x => x).ToList();

            Assert.IsTrue(testList.Any());

            this.CompleteFilterTest(testList, filterType);
        }

        [TestMethod]
        public void SelectedTreatmentOptionsMappedToFilterViewModel()
        {
            var filterType = CaFCConstants.DynamicFilterType.Treatments;

            SearchFilters allSearchFilters = this.cafcSearchClientFake.GetSearchTerms();

            List<int> testList = allSearchFilters.Treatments.Select(x => x.Id).OrderBy(x => x).ToList();

            Assert.IsTrue(testList.Any());

            this.CompleteFilterTest(testList, filterType);
        }

        private void CompleteFilterTest(List<int> testList, CaFCConstants.DynamicFilterType filterType)
        {
            List<int> selectedOptions = testList.Count > 2 ? testList.Take(2).ToList() : testList.Take(1).ToList();

            this.distanceSearchParams.Options = selectedOptions;

            var returned = modelCreator.GetCaFCFiltersViewModel(distanceSearchParams);
            var flattendList = returned.DynamicFilters
                .Where(x => x.Type == filterType)
                .SelectMany(x => x.ItemList)
                .ToList();

            List<int> returnedIds = flattendList.Select(x => x.Id).OrderBy(x => x).ToList();

            var selectedIds = flattendList.Where(x => x.Value == true).Select(x => x.Id).OrderBy(x => x);

            Assert.IsTrue(testList.SequenceEqual(returnedIds));
            Assert.IsTrue(selectedIds.SequenceEqual(selectedOptions));
        }
        
        [TestInitialize]
        public void InitClient()
        {
            this.distanceSearchParams = new SearchParameters()
            {
                Source = "London",
                Distance = 100,
                Options = null
            };

            this.fullSearchParams = new SearchParameters()
            {
                Source = "London",
                Distance = 150,
                Options = this.searchParams.ToList(),
                PageNumber = 3,
                PageSize = 5,
                Sort = 1
            };

            this.distanceSearchResults = Data.Search.DistanceSearch;
            this.fullSearchResults = Data.Search.FullSearch;

            Mock<ICafcProfileUrlHelper> mockUrlHelper = new Mock<ICafcProfileUrlHelper>();
            mockUrlHelper.Setup(x => x.GetPageUrl(It.IsAny<int>())).Returns<int>((x) => { return "/my-valid-url/" + x.ToString(); });

            Mock<ICaFCSearch> clinicSearchMock = new Mock<ICaFCSearch>();
            clinicSearchMock.Setup(x => x.GetSearchTerms()).Returns(Data.Terms.ResultObject);
            clinicSearchMock.Setup(x => x.GetClinicList(
                It.IsAny<string>(),
                It.IsAny<int?>(),
                It.IsAny<char>(),
                It.IsAny<List<int>>(),
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<int>()))
                    .Returns<string, int?, char, List<int>, int, int, int>((place, distance, fchar, options, pageSize, page, sort) 
                        => {
                            // we have only 2 possible results: for distance search and for full search
                            // distance search
                            if (options == null)
                            {
                                return Data.Search.DistanceSearch;
                            }
                            else // full search
                            {
                                return Data.Search.FullSearch;
                            }
                        });

            clinicSearchMock.Setup(x => x.GetAllClinicListJSON()).Returns(Data.AllClinicJson.JSON);

            this.serializer = new BL.Serialization.JsonSerializer();
            this.profileUrlHelper = mockUrlHelper.Object;
            this.cafcSearchClientFake = clinicSearchMock.Object;
            this.modelCreator = new CaFCSearchModelCreator(this.cafcSearchClientFake, this.profileUrlHelper, this.serializer);
        }
    }
}
