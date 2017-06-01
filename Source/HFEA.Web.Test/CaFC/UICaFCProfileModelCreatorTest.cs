using HFEA.BL.ModelCreators;
using HFEA.Connector.Contracts.CaFC;
using HFEA.Connector.Contracts.Clients.CaFC;
using HFEA.Web.ViewModel.CaFC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace HFEA.Web.Test.CaFC
{
    [TestClass]
    public class UICaFCProfileModelCreatorTest
    {
        private ICaFCProfileClient readerClientFake;
        private ICafcProfileUrlHelper readerUrlHelperFake;
        private CaFCProfileViewModel viewModel;
        private ClinicProfile rawData;

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsNullExceptionIfApiClientIsNull()
        {
            Mock<ICafcProfileUrlHelper> urlHelperMock = new Mock<ICafcProfileUrlHelper>();
            var modelCreator = new CaFCProfileModelCreator(null, urlHelperMock.Object);
        }

        [TestMethod]
        public void ModelCreatorInstantiatesIfApiClientIsNotNull()
        {
            Mock<ICaFCProfileClient> clientMock = new Mock<ICaFCProfileClient>();
            Mock<ICafcProfileUrlHelper> urlHelperMock = new Mock<ICafcProfileUrlHelper>();
            var modelCreator = new CaFCProfileModelCreator(clientMock.Object, urlHelperMock.Object);
            Assert.IsNotNull(modelCreator);
        }

        [TestMethod]
        public void ViewModelHasClinicOpeningHoursDataForSevenDays()
        {
            var data = viewModel.ClinicDetailsInfo.OpeningHoursList;

            Assert.IsNotNull(data);

            var existingDays = data.Select(x => x.FromDay).ToList();

            Assert.IsTrue(existingDays.Count() == 7 && existingDays.Distinct().Count() == 7);
            Assert.IsTrue(Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>().All(x => existingDays.Contains(x)));
        }

        [TestMethod]
        public void ClinicOpeningHoursClosedFlagMappedSuccessfully()
        {
            var data = viewModel.ClinicDetailsInfo.OpeningHoursList;

            var closedOn = data.Where(x => !x.IsOpened).Select(x => x.FromDay).ToList();

            Assert.IsTrue(closedOn.Count() == 2);
            Assert.IsTrue(closedOn.Contains(DayOfWeek.Saturday));
            Assert.IsTrue(closedOn.Contains(DayOfWeek.Sunday));
        }

        [TestMethod]
        public void PatientInfoRaitingMappedSuccessfully()
        {
            var raw = this.rawData.PatientExperiences;
            var view = this.viewModel.PatientExperiences;

            Assert.IsTrue(raw.OverallScore == view.OverallScore);
            Assert.IsTrue(raw.NumberOfReviews == view.NumberOfReviews);

            // TODO: star rating and number of reviews
            Assert.IsTrue(raw.AccuracyOfCostEstimate.ScoreValue1 == view.AccuracyOfCostEstimate.ScoreValue1
                && raw.AccuracyOfCostEstimate.ScoreValue2 == view.AccuracyOfCostEstimate.ScoreValue2
                && raw.AccuracyOfCostEstimate.ScoreValue3 == view.AccuracyOfCostEstimate.ScoreValue3
                && raw.AccuracyOfCostEstimate.ScoreValue4 == view.AccuracyOfCostEstimate.ScoreValue4
                && raw.AccuracyOfCostEstimate.ScoreValue5 == view.AccuracyOfCostEstimate.ScoreValue5);
        }

        [TestMethod]
        public void PatientInfoRaitingShortRatingListMappedSuccessfully()
        {
            var raw = this.rawData.PatientExperiences;
            var view = this.viewModel.PatientExperiences;

            Assert.IsTrue(raw.OverallScore == view.OverallScore);
            Assert.IsTrue(raw.NumberOfReviews == view.NumberOfReviews);

            Assert.IsTrue(view.ShortRatingsList.Count == 5); // TODO update mock & assertion after API is complete

            var questions = view.ShortRatingsList.Select(x => x.Question).Distinct().ToList();
            Assert.IsTrue(view.ShortRatingsList.Count == questions.Count);
            Assert.IsTrue(view.ShortRatingsList.All(x => x.NumberOfReviews > 0));
            Assert.IsTrue(view.ShortRatingsList.All(x => x.OverallScore > 0f));
        }

        [TestMethod]
        public void ChartDataIsComplete()
        {
            Assert.IsNotNull(this.viewModel.BirthStatsInfo.ChartData);

            Assert.IsTrue(this.viewModel.BirthStatsInfo.ChartData.XAxisLabelList.Count == 12);
            Assert.IsTrue(this.viewModel.BirthStatsInfo.ChartData.PregnancyRatesDataList.Count == 12);
            Assert.IsTrue(this.viewModel.BirthStatsInfo.ChartData.PregnancyRatesDataList.Count == 12);            
        }

        [TestMethod]
        public void IsGeneralClinicInformationMapped()
        {
            Assert.IsNotNull(this.viewModel.GeneralInfo);
            Assert.IsTrue(this.viewModel.GeneralInfo.Id != 0);
        }

        [TestMethod]
        public void IsClinicGeneralInfoMapped()
        {
            // Check basic mapping. Consider adding test for other fields
            Assert.IsNotNull(this.viewModel.GeneralInfo);
            Assert.IsTrue(this.viewModel.GeneralInfo.Id != 0);
        }

        [TestMethod]
        public void IsClinicDetailsInfoMapped()
        {
            // Not all fields are tested
            Assert.IsNotNull(this.viewModel.ClinicDetailsInfo);
            Assert.IsTrue(this.viewModel.ClinicDetailsInfo.AddressLinesList.Any());
            Assert.IsTrue(this.viewModel.ClinicDetailsInfo.OpeningHoursList.Any());

            Assert.IsTrue(this.viewModel.ClinicDetailsInfo.ClinicServiceList.Any());
            Assert.IsTrue(this.viewModel.ClinicDetailsInfo.OpeningHoursList.Any());

            Assert.IsNotNull(this.viewModel.ClinicDetailsInfo.MapInfo);
        }

        [TestMethod]
        public void IsClinicBirthStatsInfoMapped()
        {
            // Not all fields are tested
            Assert.IsNotNull(this.viewModel.BirthStatsInfo);
            Assert.IsNotNull(this.viewModel.BirthStatsInfo.BirthsPerEggCollection);
            Assert.IsNotNull(this.viewModel.BirthStatsInfo.BirthsPerEmbryo);
            Assert.IsNotNull(this.viewModel.BirthStatsInfo.DIBirths);
            Assert.IsNotNull(this.viewModel.BirthStatsInfo.IUIBirths);
            Assert.IsNotNull(this.viewModel.BirthStatsInfo.MultipleBirthsPerCycle);
        }

        [TestMethod]
        public void IsInspectionRatingInfoMapped()
        {
            // Not all fields are tested
            Assert.IsNotNull(this.viewModel.InspectionRatings);
            Assert.IsTrue(this.viewModel.InspectionRatings.OverallScore > 0);
        }

        [TestMethod]
        public void IsWaitingTimesInfoMapped()
        {
            // Not all fields are tested
            Assert.IsNotNull(this.viewModel.WaitingTimesInfo);
            Assert.IsNotNull(this.viewModel.WaitingTimesInfo.EggDonors);
            Assert.IsNotNull(this.viewModel.WaitingTimesInfo.EmbryoDonors);
            Assert.IsNotNull(this.viewModel.WaitingTimesInfo.SpermDonors);

            string testOne = string.Format(
                "{0}{1}{2}{3}{4}",
                this.viewModel.WaitingTimesInfo.EggDonors.Asian,
                this.viewModel.WaitingTimesInfo.EggDonors.White,
                this.viewModel.WaitingTimesInfo.EggDonors.Black,
                this.viewModel.WaitingTimesInfo.EggDonors.Mixed,
                this.viewModel.WaitingTimesInfo.EggDonors.Other);

            Assert.IsFalse(string.IsNullOrEmpty(testOne));
        }

        [TestMethod]
        public void SatelliteClinicsListIsMapped()
        {
            var raw = this.rawData.SatelliteClinics;
            var satellites = this.viewModel.ClinicDetailsInfo.SatelliteClinicList;
            var transport = this.viewModel.ClinicDetailsInfo.TransportClinicList;

            Assert.IsTrue(raw.Count == 1);
            Assert.IsTrue(satellites.Count == 1);
            Assert.IsNull(transport);

            var sat = satellites[0];
            Assert.IsTrue(raw[0].LinkCentreName == sat.CentreName);
            Assert.IsTrue(sat.CentrePhoneList.Count == 2);
            Assert.IsTrue(sat.AddressLinesList.Count > 0);
            Assert.IsTrue(sat.AddressLinesList.Contains("W1B 1QJ"));
        }

        [TestInitialize]
        public void InitClient()
        {
            BL.AutoMapperInit.Init();
            this.rawData = JsonConvert.DeserializeObject<ClinicProfile>(Data.CafcProfileData.Profile);

            Mock<ICaFCProfileClient> clientMock = new Mock<ICaFCProfileClient>();
            Mock<ICafcProfileUrlHelper> urlHelperMock = new Mock<ICafcProfileUrlHelper>();
            clientMock
                .Setup(x => x.GetClinicProfile(It.IsAny<int>()))
                .Returns(this.rawData);

            this.readerClientFake = clientMock.Object;
            this.readerUrlHelperFake = urlHelperMock.Object;

            this.viewModel = new CaFCProfileModelCreator(this.readerClientFake, this.readerUrlHelperFake).GetViewModel(1);
        }
    }
}
