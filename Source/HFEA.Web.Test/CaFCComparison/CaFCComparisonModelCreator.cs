using HFEA.BL.ModelCreators;
using HFEA.Connector.Contracts.CaFC.Comparison;
using HFEA.Connector.Contracts.Clients.CaFC;
using HFEA.Core.Extensions;
using HFEA.Web.ViewModel.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.Test.CaFCComparison
{
    [TestClass]
    public class CaFCComparisonModelCreatorTest
    {
        private readonly int[] availableClinicIds = new int[] { 4, 6, 10603 };
        private ICaFCComparisonClient reader;
        private CaFCComparisonModelCreator modelCreator;

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsNullError_If_No_DataReader()
        {
            var tmp = new CaFCComparisonModelCreator(null);
        }

        [TestMethod]
        public void Model_Has_Some_Data()
        {            
            var model = modelCreator.GetData(availableClinicIds);

            var clinicIds = model.ClinicList.Select(x => x.ClinicId);

            Assert.IsTrue(availableClinicIds.Count() == clinicIds.Count());
            Assert.IsTrue(availableClinicIds.All(x => clinicIds.Contains(x)));
        }

        [TestMethod]
        public void Eligibility_List_Rows_Count_Match_Concatened_Data_From_All_Clinics()
        {            
            var model = modelCreator.GetData(availableClinicIds);
            var rawData = this.reader.GetComparisonData(availableClinicIds);

            var uniqueIds = rawData
                .SelectMany(x => x.EligibilityAndFunding)
                .Select(x => x.Id)
                .Distinct();

            var modelIds = model.EligibilityItems.Select(x => x.Id).ToList();

            Assert.IsTrue(uniqueIds.Any());
            Assert.IsTrue(uniqueIds.Count() > 0 && uniqueIds.Count() == modelIds.Count);
            Assert.IsTrue(modelIds.All(x => x > 0));
            Assert.IsTrue(modelIds.All(x => uniqueIds.Contains(x)));            
        }

        [TestMethod]
        public void Treatment_List_Rows_Count_Match_Concatened_Data_From_All_Clinics()
        {            
            var model = modelCreator.GetData(availableClinicIds);
            var rawData = this.reader.GetComparisonData(availableClinicIds);

            var uniqueIds = rawData
                .SelectMany(x => x.TreatmentsOffered)
                .Select(x => x.Id)
                .Distinct();

            var modelIds = model.TreatmentItems.Select(x => x.Id).ToList();

            Assert.IsTrue(uniqueIds.Any());
            Assert.IsTrue(uniqueIds.Count() == modelIds.Count);
            Assert.IsTrue(modelIds.All(x => x > 0));
            Assert.IsTrue(modelIds.All(x => uniqueIds.Contains(x)));
        }

        [TestMethod]
        public void DonorServices_List_Rows_Count_Match_Concatened_Data_From_All_Clinics()
        {
            var model = modelCreator.GetData(availableClinicIds);
            var rawData = this.reader.GetComparisonData(availableClinicIds);

            var uniqueIds = rawData
                .SelectMany(x => x.DonorServices)
                .Select(x => x.Id)
                .Distinct();

            var modelIds = model.DonorServiceItems.Select(x => x.Id).ToList();

            Assert.IsTrue(uniqueIds.Any());
            Assert.IsTrue(uniqueIds.Count() == modelIds.Count);
            Assert.IsTrue(modelIds.All(x => x > 0));
            Assert.IsTrue(modelIds.All(x => uniqueIds.Contains(x)));
        }

        [TestMethod]
        public void Counselling_List_Rows_Count_Match_Concatened_Data_From_All_Clinics()
        {            
            var model = modelCreator.GetData(availableClinicIds);
            var rawData = this.reader.GetComparisonData(availableClinicIds);

            var uniqueIds = rawData
                .SelectMany(x => x.CounsellingAndSupport)
                .Select(x => x.Id)
                .Distinct();

            var modelIds = model.CounsellingItems.Select(x => x.Id).ToList();

            Assert.IsTrue(uniqueIds.Any());
            Assert.IsTrue(uniqueIds.Count() == modelIds.Count);
            Assert.IsTrue(modelIds.All(x => x > 0));
            Assert.IsTrue(modelIds.All(x => uniqueIds.Contains(x)));
        }

        [TestMethod]
        public void Staffing_List_Rows_Count_Match_Concatened_Data_From_All_Clinics()
        {            
            var model = modelCreator.GetData(availableClinicIds);
            var rawData = this.reader.GetComparisonData(availableClinicIds);

            var uniqueIds = rawData
                .SelectMany(x => x.Staff)
                .Select(x => x.Id)
                .Distinct();

            var modelIds = model.StaffingItems.Select(x => x.Id).ToList();

            Assert.IsTrue(uniqueIds.Any());
            Assert.IsTrue(uniqueIds.Count() == modelIds.Count);
            Assert.IsTrue(modelIds.All(x => x > 0));
            Assert.IsTrue(modelIds.All(x => uniqueIds.Contains(x)));
        }

        [TestMethod]
        public void Facilities_List_Rows_Count_Match_Concatened_Data_From_All_Clinics()
        {            
            var model = modelCreator.GetData(availableClinicIds);
            var rawData = this.reader.GetComparisonData(availableClinicIds);

            var uniqueIds = rawData
                .SelectMany(x => x.Facilities)
                .Select(x => x.Id)
                .Distinct();

            var modelIds = model.FacilitiesItems.Select(x => x.Id).ToList();

            Assert.IsTrue(uniqueIds.Any());
            Assert.IsTrue(uniqueIds.Count() == modelIds.Count);
            Assert.IsTrue(modelIds.All(x => x > 0));
            Assert.IsTrue(modelIds.All(x => uniqueIds.Contains(x)));
        }

        [TestMethod]
        public void Eligibility_List_Rows_Match_Global_List_For_Each_Clinic()
        {            
            var model = modelCreator.GetData(availableClinicIds);
            var rawData = this.reader.GetComparisonData(availableClinicIds);
            
            var rowTitleIds = model.EligibilityItems.Select(x => x.Id).ToList();
            Assert.IsTrue(model.ClinicList.All(x => x.Eligibility.Count == rowTitleIds.Count()));
            Assert.IsTrue(model.ClinicList.All(x => x.Eligibility.All(k => rowTitleIds.Contains(k.Id))));
        }

        [TestMethod]
        public void Treatment_List_Rows_Match_Global_List_For_Each_Clinic()
        {            
            var model = modelCreator.GetData(availableClinicIds);
            var rawData = this.reader.GetComparisonData(availableClinicIds);

            var rowTitleIds = model.TreatmentItems.Select(x => x.Id).ToList();
            Assert.IsTrue(model.ClinicList.All(x => x.Treatments.Count == rowTitleIds.Count()));
            Assert.IsTrue(model.ClinicList.All(x => x.Treatments.All(k => rowTitleIds.Contains(k.Id))));
        }

        [TestMethod]
        public void DonorServices_List_Rows_Match_Global_List_For_Each_Clinic()
        {            
            var model = modelCreator.GetData(availableClinicIds);
            var rawData = this.reader.GetComparisonData(availableClinicIds);

            var rowTitleIds = model.DonorServiceItems.Select(x => x.Id).ToList();
            Assert.IsTrue(model.ClinicList.All(x => x.DonorServices.Count == rowTitleIds.Count()));
            Assert.IsTrue(model.ClinicList.All(x => x.DonorServices.All(k => rowTitleIds.Contains(k.Id))));
        }

        [TestMethod]
        public void Counselling_List_Rows_Match_Global_List_For_Each_Clinic()
        {
            var model = modelCreator.GetData(availableClinicIds);
            var rawData = this.reader.GetComparisonData(availableClinicIds);

            var rowTitleIds = model.CounsellingItems.Select(x => x.Id).ToList();
            Assert.IsTrue(model.ClinicList.All(x => x.CounsellingAndSupport.Count == rowTitleIds.Count()));
            Assert.IsTrue(model.ClinicList.All(x => x.CounsellingAndSupport.All(k => rowTitleIds.Contains(k.Id))));
        }

        [TestMethod]
        public void Staffing_List_Rows_Match_Global_List_For_Each_Clinic()
        {            
            var model = modelCreator.GetData(availableClinicIds);
            var rawData = this.reader.GetComparisonData(availableClinicIds);

            var rowTitleIds = model.StaffingItems.Select(x => x.Id).ToList();
            Assert.IsTrue(model.ClinicList.All(x => x.Staffing.Count == rowTitleIds.Count()));
            Assert.IsTrue(model.ClinicList.All(x => x.Staffing.All(k => rowTitleIds.Contains(k.Id))));
        }

        [TestMethod]
        public void Facilities_List_Rows_Match_Global_List_For_Each_Clinic()
        {            
            var model = modelCreator.GetData(availableClinicIds);
            var rawData = this.reader.GetComparisonData(availableClinicIds);

            var rowTitleIds = model.FacilitiesItems.Select(x => x.Id).ToList();
            Assert.IsTrue(model.ClinicList.All(x => x.Facilities.Count == rowTitleIds.Count()));
            Assert.IsTrue(model.ClinicList.All(x => x.Facilities.All(k => rowTitleIds.Contains(k.Id))));
        }

        [TestMethod]
        public void Satellite_Clinics_Are_Populated()
        {            
            var model = modelCreator.GetData(availableClinicIds);
            var rawData = this.reader.GetComparisonData(availableClinicIds)
                .Where(x => x.SatelliteClinics.Any(m => m.LinkType == (int)CaFCConstants.ClinicType.Satellite))
                .FirstOrDefault();

            Assert.IsNotNull(rawData);

            var rawDataClinicList = rawData.SatelliteClinics
                .Where(m => m.LinkType == (int)CaFCConstants.ClinicType.Satellite)
                .Select(x => x.LinkCentreName)
                .ToList();
                
            var resultList = model.ClinicList.First(x => x.ClinicId == rawData.Id)
                .SatelliteClinicList
                .Select(x => x.CentreName)
                .ToList();

            Assert.IsTrue(resultList.Count == rawDataClinicList.Count);
            Assert.IsTrue(resultList.All(x => rawDataClinicList.Contains(x)));
        }

        [TestMethod]
        public void Transport_Clinics_Are_Populated()
        {            
            var model = modelCreator.GetData(availableClinicIds);
            var rawData = this.reader.GetComparisonData(availableClinicIds)
                .Where(x => x.SatelliteClinics.Any(m => m.LinkType == (int)CaFCConstants.ClinicType.Transport))
                .FirstOrDefault();

            Assert.IsNotNull(rawData);

            var rawDataClinicList = rawData.SatelliteClinics
                .Where(m => m.LinkType == (int)CaFCConstants.ClinicType.Transport)
                .Select(x => x.LinkCentreName)
                .ToList();

            var resultList = model.ClinicList.First(x => x.ClinicId == rawData.Id)
                .TransportClinicList
                .Select(x => x.CentreName)
                .ToList();

            Assert.IsTrue(resultList.Count == rawDataClinicList.Count);
            Assert.IsTrue(resultList.All(x => rawDataClinicList.Contains(x)));
        }

        [TestMethod]
        public void Associated_Clinics_Are_Empty_If_No_Data()
        {            
            var model = modelCreator.GetData(availableClinicIds);
            var rawData = this.reader.GetComparisonData(availableClinicIds)
                .Where(x => x.SatelliteClinics.IsNullOrEmpty())
                .FirstOrDefault();

            Assert.IsNotNull(rawData);

            var clinic = model.ClinicList.First(x => x.ClinicId == rawData.Id);

            Assert.IsTrue(clinic.SatelliteClinicList.IsNullOrEmpty());
            Assert.IsTrue(clinic.TransportClinicList.IsNullOrEmpty());
        }

        [TestMethod]
        public void Gamete_Availability_Data_Exists()
        {            
            var clinic = modelCreator.GetData(availableClinicIds).ClinicList.First();

            Assert.IsNotNull(clinic.GameteAvailability.Asian.Egg);
            Assert.IsNotNull(clinic.GameteAvailability.Asian.Embryo);
            Assert.IsNotNull(clinic.GameteAvailability.Asian.Sperm);

            Assert.IsNotNull(clinic.GameteAvailability.Black.Egg);
            Assert.IsNotNull(clinic.GameteAvailability.Black.Embryo);
            Assert.IsNotNull(clinic.GameteAvailability.Black.Sperm);

            Assert.IsNotNull(clinic.GameteAvailability.Mixed.Egg);
            Assert.IsNotNull(clinic.GameteAvailability.Mixed.Embryo);
            Assert.IsNotNull(clinic.GameteAvailability.Mixed.Sperm);

            Assert.IsNotNull(clinic.GameteAvailability.Other.Egg);
            Assert.IsNotNull(clinic.GameteAvailability.Other.Embryo);
            Assert.IsNotNull(clinic.GameteAvailability.Other.Sperm);

            Assert.IsNotNull(clinic.GameteAvailability.White.Egg);
            Assert.IsNotNull(clinic.GameteAvailability.White.Embryo);
            Assert.IsNotNull(clinic.GameteAvailability.White.Sperm);
        }

        [TestMethod]
        public void Opening_Hours_Data_Exists()
        {
            var clinics = modelCreator.GetData(availableClinicIds)
                .ClinicList
                .Where(x => !x.OpeningTimesList.IsNullOrEmpty());

            var rawData = this.reader.GetComparisonData(availableClinicIds)
                .Where(x => !x.OpeningTimes.IsNullOrEmpty());

            Assert.IsTrue(clinics.Count() > 0);
            Assert.IsTrue(clinics.Count() == rawData.Count());
        }

        [TestMethod]
        public void Address_Data_Exists()
        {
            var clinics = modelCreator.GetData(availableClinicIds)
                .ClinicList
                .Where(x => !x.AddressLines.IsNullOrEmpty());

            var rawData = this.reader.GetComparisonData(availableClinicIds)
                .Where(x => x.MainAddress != null);

            Assert.IsTrue(clinics.Count() > 0);
            Assert.IsTrue(clinics.Count() == rawData.Count());
        }

        [TestInitialize]
        public void Init()
        {
            var apiClientMock = new Mock<ICaFCComparisonClient>();
            apiClientMock
                .Setup(x => x.GetComparisonData(It.IsAny<int[]>()))
                .Returns<int[]>(x => GetComparisonData(x));

            this.reader = apiClientMock.Object;
            this.modelCreator = new CaFCComparisonModelCreator(this.reader);
        }

        private List<ComparisonClinicInfo> GetComparisonData(int[] clinicIds)
        {
            return Data.ThreeClinicsData.Clinics_4_6_10603
                .Where(x => clinicIds.Contains(x.Id))
                .ToList();
        }
    }
}
