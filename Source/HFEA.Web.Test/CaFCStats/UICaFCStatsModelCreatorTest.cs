using HFEA.BL.Contracts;
using HFEA.BL.ModelCreators;
using HFEA.BL.Readers;
using HFEA.Connector.Contracts.CaFC;
using HFEA.Connector.Contracts.CaFC.Stats;
using HFEA.Connector.Contracts.Clients.CaFC;
using HFEA.Connector.Service.Clients.CaFC;
using HFEA.Web.ViewModel.API;
using HFEA.Web.ViewModel.CaFC;
using HFEA.Web.ViewModel.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HFEA.Web.Test.CaFCStats
{
    [TestClass]
    public class UICaFCStatsModelCreatorTest
    {
        private const int ClinicId = 4;
        private const int ClinicIdWithIncomlpeteData = 321;
        private ICaFCStatsClient apiClientFake;
        private ICafcProfileUrlHelper urlHelper;
        private CaFCStatsModelCreator modelCreator;

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ClinicStats_ConstructorThrowsNullExceptionIfApiClientIsNull()
        {
            var modelCreator = new CaFCStatsModelCreator(null, this.urlHelper);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ClinicStats_Constructor_ThrowsNullException_If_UrlHelper_IsNull()
        {
            var modelCreator = new CaFCStatsModelCreator(this.apiClientFake, null);
        }

        [TestMethod]
        public void ClinicStats_Filter_Dynamic_YearList_Populated_If_Only_ClinicId_Provided()
        {
            var combinations = this.modelCreator.GetAvailableFiltersByData(4);

            Assert.IsNotNull(combinations.Years);
            Assert.IsTrue(combinations.Years.Count > 0);

            Assert.IsNull(combinations.Treatments);
            Assert.IsNull(combinations.Ages);
            Assert.IsNull(combinations.Sources);
            
        }

        [TestMethod]
        public void ClinicStats_Filter_Dynamic_Year_Treatment_Lists_Populated_If_Only_ClinicId_Year_Treatment_Provided()
        {
            var combinations = this.modelCreator.GetAvailableFiltersByData(4, "2014");
                        
            Assert.IsNotNull(combinations.Treatments);
            Assert.IsTrue(combinations.Years.Count > 0);
            Assert.IsTrue(combinations.Treatments.Count > 0);

            Assert.IsNull(combinations.Ages);
            Assert.IsNull(combinations.Sources);            
        }

        [TestMethod]
        public void ClinicStats_Filter_Dynamic_Year_Treatment_Ages_Lists_Populated_If_Only_ClinicId_And_Year_Provided()
        {
            var combinations = this.modelCreator.GetAvailableFiltersByData(4, "2014", "ivf_icsi");

            Assert.IsNotNull(combinations.Ages);
            Assert.IsTrue(combinations.Years.Count > 0);
            Assert.IsTrue(combinations.Treatments.Count > 0);
            Assert.IsTrue(combinations.Ages.Count > 0);

            Assert.IsNull(combinations.Sources);
        }

        [TestMethod]
        public void ClinicStats_Filter_Dynamic_All_Lists_Populated()
        {
            var combinations = this.modelCreator.GetAvailableFiltersByData(4, "2014", "ivf_icsi", "b35", "n/a");

            Assert.IsNotNull(combinations.Sources);
            Assert.IsTrue(combinations.Years.Count > 0);
            Assert.IsTrue(combinations.Treatments.Count > 0);
            Assert.IsTrue(combinations.Ages.Count > 0);
            Assert.IsTrue(combinations.Sources.Count > 0);
        }
        
        [TestMethod]
        public void ClinicStats_ViewModel_Is_Not_Null()
        {
            var model = this.modelCreator.GetViewModel(ClinicId, "", "", "", "", CaFCConstants.StatsTreatmentType.PerEmbryoTransferred);
            Assert.IsNotNull(model);                        
            Assert.IsTrue(model.ClinicId == ClinicId);
            Assert.IsTrue(!string.IsNullOrEmpty(model.ClinicName));
        }

        [TestMethod]
        public void ClinicStats_ViewModel_FiltersData_Is_Not_Null()
        {
            var model = this.modelCreator
                .GetViewModel(ClinicId, "", "", "", "", CaFCConstants.StatsTreatmentType.PerEmbryoTransferred)
                ?.StatsParameters;

            Assert.IsNotNull(model);
        }

        [TestMethod]
        public void ClinicStats_ViewModel_GenericStats_Is_Not_Null()
        {
            var model = this.modelCreator
                .GetViewModel(ClinicId, "", "", "", "", CaFCConstants.StatsTreatmentType.PerEmbryoTransferred)
                ?.GenericStatsData;
            Assert.IsNotNull(model);
            Assert.IsNotNull(model.ChartData);
            Assert.IsNotNull(model.EmbryoTransferredAverage);
            Assert.IsNotNull(model.TopRowDataList);
        }               

        [TestMethod]
        public void ClinicStats_ViewModel_TreatmentsData_Is_Not_Null()
        {
            var model = this.modelCreator
                .GetViewModel(ClinicId, "", "", "", "", CaFCConstants.StatsTreatmentType.PerEmbryoTransferred)
                ?.TreatmentStatsData;

            Assert.IsNotNull(model);
            Assert.IsNotNull(model.CancellationBeforeCollectionData);
            Assert.IsNotNull(model.CancellationBeforeTransferData);
            Assert.IsNotNull(model.EmbryosTransferredData);
        }

        [TestMethod]
        public void ClinicStats_ViewModel_TreatmentsData_Collection_Counts_Match()
        {
            var rawData = this.apiClientFake.GetClinicStats(ClinicId, "", "", "", "")
                .FullDataSet;
            var model = this.modelCreator
                .GetViewModel(ClinicId, "", "", "", "", CaFCConstants.StatsTreatmentType.PerEmbryoTransferred)
                ?.TreatmentStatsData;

            Assert.AreEqual<int>(model.CancellationBeforeCollectionData.Count, rawData.NumberOfCyclesCancelledBeforeEggsWereCollected.Count);
            Assert.AreEqual<int>(model.CancellationBeforeTransferData.Count, rawData.NumberOfCyclesCancelledBetweenEggCollectionAndEmbryoTransfer.Count);
            Assert.AreEqual<int>(model.EmbryosTransferredData.Count, rawData.NumberOfEmbryosTransferred.Count);
        }

        [TestMethod]
        public void ClinicStats_ViewModel_ClinicComparisonData_Is_Not_Null()
        {
            var model = this.modelCreator
                .GetViewModel(ClinicId, "", "", "", "", CaFCConstants.StatsTreatmentType.PerEmbryoTransferred)
                ?.ClinicVsNationalComparisonData;

            Assert.IsNotNull(model);
            Assert.IsTrue(model.CurrentTreatmentType != CaFCConstants.StatsTreatmentType.Unknown);
            Assert.IsNotNull(model.PerCycleDataList);
            Assert.IsNotNull(model.PerEmbryoDataList);
        }

        [TestMethod]
        public void ClinicStats_ViewModel_NationalAverage_Is_Not_Zero()
        {
            var model = this.modelCreator
                .GetViewModel(ClinicIdWithIncomlpeteData, "", "", "", "", CaFCConstants.StatsTreatmentType.PerEmbryoTransferred)
                ?.ClinicVsNationalComparisonData;

            Assert.IsNotNull(model);
            Assert.IsTrue(model.CurrentTreatmentType != CaFCConstants.StatsTreatmentType.Unknown);
            Assert.IsNotNull(model.PerCycleDataList);

            var checkValue = model.PerCycleDataList
                .FirstOrDefault(x => x.ClinicSuccessLikelinessTitle == "Predicated chance of an average patient becoming pregnant");

            Assert.IsTrue(checkValue.ClinicRate == 0);
            Assert.IsTrue(checkValue.NationalAverage == 38);
        }

        [TestMethod]
        public void ClinicStats_ViewModel_ClinicComparisonData_Counts_Match()
        {
            var rawData = this.apiClientFake.GetClinicStats(ClinicId, "", "", "", "")
                .FullDataSet;
            var model = this.modelCreator
                .GetViewModel(ClinicId, "", "", "", "", CaFCConstants.StatsTreatmentType.PerEmbryoTransferred)
                ?.ClinicVsNationalComparisonData;

            Assert.AreEqual<int>(model.PerCycleDataList.Count, rawData.PregnanciesAndLiveBirthsPerTreatmentCycle.Count);
            Assert.AreEqual<int>(model.PerEmbryoDataList.Count, rawData.PregnanciesAndLiveBirthsPerEmbryoTransferred.Count);
        }

        [TestMethod]
        public void ClinicStats_ViewModel_AgeStatsData_Is_Not_Null()
        {           
            var model = this.modelCreator
                .GetViewModel(ClinicId, "", "", "", "", CaFCConstants.StatsTreatmentType.PerEmbryoTransferred)
                ?.AgeStatsData;
            Assert.IsNotNull(model); 
        }

        [TestMethod]
        public void ClinicStats_ViewModel_AgeStatsData_Count_Matches()
        {
            var rawData = this.apiClientFake.GetClinicStats(ClinicId, "", "", "", "")
               .FullDataSet;
            var model = this.modelCreator
                .GetViewModel(ClinicId, "", "", "", "", CaFCConstants.StatsTreatmentType.PerEmbryoTransferred)
                ?.AgeStatsData;
            Assert.AreEqual<int>(model.Count, rawData.AgeSplitOfPatients.Count);
        }

        [TestInitialize]
        public void InitClient()
        {
            Mock<ICaFCStatsClient> apiClient = new Mock<ICaFCStatsClient>();
            apiClient.Setup(x => x.GetClinicStats(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
                .Returns<int, string, string, string, string>((clinicId, year, age, treatment, source) =>
                {
                    if (clinicId == ClinicIdWithIncomlpeteData)
                    {
                        return Data.Stats.Data321;
                    }

                    return Data.Stats.Data;
                }
                );
            apiClient.Setup(x => x.GetClinicSearchFilters(It.IsAny<int>()))
                .Returns(Data.Filters.Data);

            Mock<ICafcProfileUrlHelper> urlHelperFake = new Mock<ICafcProfileUrlHelper>();
            urlHelperFake
                .Setup(x => x.GetPageUrl(It.IsAny<int>()))
                .Returns<int>(id => "/fake-url/" + id.ToString());

            this.apiClientFake = apiClient.Object;
            this.urlHelper = urlHelperFake.Object;
            this.modelCreator = new CaFCStatsModelCreator(this.apiClientFake, this.urlHelper);
        }
    }
}
