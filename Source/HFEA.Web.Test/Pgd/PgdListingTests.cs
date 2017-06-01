using HFEA.BL.ModelCreators;
using HFEA.Connector.Contracts.Clients.ReferenceData;
using HFEA.Core.Extensions;
using HFEA.Web.ViewModel.Constants;
using HFEA.Web.ViewModel.PGD;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.Test.Pgd
{
    [TestClass]
    public class PgdListingTests
    {
        private IReferenceDataReader refReader;
        private IPgdConditionsCmsReader cmsReader;
        PgdListingModelCreator modelCreator;


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_Throws_NullException_If_No_RefDataReader()
        {
            var test = new PgdListingModelCreator(null, cmsReader);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_Throws_NullException_If_No_CmsDataReader()
        {
            var test = new PgdListingModelCreator(refReader, null);
        }

        [TestMethod]
        public void Some_Data_Is_Returned()
        {
            var param = new PgdSearchFilters() { PageSize = 10 };
            var result = this.modelCreator.GetData(0, param);

            Assert.IsTrue(result?.ItemList != null && result.ItemList.Any());
        }

        [TestMethod]
        public void Full_DataSet_Info_Is_Returned()
        {
            int pageId = 0;
            var param = new PgdSearchFilters() { PageSize = 10 };
            var result = this.modelCreator.GetData(pageId, param);

            int totalCount = this.refReader.GetPgdConditionsData().Count 
                + this.cmsReader.GetAllConditionByListingPageId(pageId).Count;

            Assert.IsTrue(result?.ItemList.TotalRecords == totalCount);
        }

        [TestMethod]
        public void Dataset_Is_Filtered_By_Approved_Status()
        {
            int pageId = 0;
            var param = new PgdSearchFilters() { PageSize = int.MaxValue, Status = PgdConstants.Status.Approved };
            var result = this.modelCreator.GetData(pageId, param);

            /// all Approved items come from API data source
            List<int> approvedItems = this.refReader
                .GetPgdConditionsData()
                .Select(x => x.Id)
                .ToList();

            Assert.IsTrue(result?.ItemList.TotalRecords == approvedItems.Count);
            Assert.IsTrue(result.ItemList.All(x => approvedItems.Contains(x.Id)));
        }

        [TestMethod]
        public void Dataset_Is_Filtered_By_AwaitingApproval_Status()
        {
            int pageId = 0;
            var param = new PgdSearchFilters() { PageSize = int.MaxValue, Status = PgdConstants.Status.AwaitingApproval };
            var result = this.modelCreator.GetData(pageId, param);

            /// all AwaitingApproval items come from CMS data source
            List<int> awaitingItems = this.cmsReader
                .GetAllConditionByListingPageId(pageId)
                .Select(x => x.Id)
                .ToList();

            Assert.IsTrue(result?.ItemList.TotalRecords == awaitingItems.Count);
            Assert.IsTrue(result.ItemList.All(x => awaitingItems.Contains(x.Id)));
        }

        [TestMethod]
        public void Dataset_Is_Filtered_By_Condition_Name_Case_Insensitive()
        {
            int pageId = 0;
            string searchWord = "SynDroMe";
            var param = new PgdSearchFilters() { PageSize = int.MaxValue, Condition = searchWord};
            var result = this.modelCreator.GetData(pageId, param);

            List<string> approvedItems = this.refReader
                .GetPgdConditionsData()
                .Where(x => x.Name != null && x.Name.ToLower().Contains(searchWord.ToLower()))
                .Select(x => x.Description)
                .ToList();

            List<string> awaitingItems = this.cmsReader
                .GetAllConditionByListingPageId(pageId)
                .Where(x => x.Name.ToLower().Contains(searchWord.ToLower()))
                .Select(x => x.OMOIMM)
                .ToList();
                        
            List<string> combined = approvedItems.Concat(awaitingItems).ToList();

            Assert.IsTrue(approvedItems.Any());
            Assert.IsTrue(awaitingItems.Any());
            Assert.IsTrue(awaitingItems.Count + approvedItems.Count == combined.Count);

            Assert.IsTrue(result?.ItemList.TotalRecords == combined.Count);
            Assert.IsTrue(result.ItemList.All(x => combined.Contains(x.OMOIMM)));
        }

        [TestMethod]
        public void Dataset_Is_Filtered_By_OMOIMM_Case_Insensitive()
        {
            int pageId = 0;
            string searchWord = "00";
            var param = new PgdSearchFilters() { PageSize = int.MaxValue, OMOIMM = searchWord };
            var result = this.modelCreator.GetData(pageId, param);

            List<string> approvedItems = this.refReader
                .GetPgdConditionsData()
                .Where(x => x.Description != null && x.Description.ToLower().Contains(searchWord.ToLower()))
                .Select(x => x.Description)
                .ToList();

            List<string> awaitingItems = this.cmsReader
                .GetAllConditionByListingPageId(pageId)
                .Where(x => x.OMOIMM.ToLower().Contains(searchWord.ToLower()))
                .Select(x => x.OMOIMM)
                .ToList();

            List<string> combined = approvedItems.Concat(awaitingItems).ToList();

            Assert.IsTrue(approvedItems.Any());
            Assert.IsTrue(awaitingItems.Any());
            Assert.IsTrue(awaitingItems.Count + approvedItems.Count == combined.Count);

            Assert.IsTrue(result?.ItemList.TotalRecords == combined.Count);
            Assert.IsTrue(result.ItemList.All(x => combined.Contains(x.OMOIMM)));
        }

        [TestInitialize]
        public void Init()
        {
            Mock<IReferenceDataReader> refReaderMock = new Mock<IReferenceDataReader>();
            refReaderMock.Setup(x => x.GetPgdConditionsData()).Returns(Data.ApiData.FullList);

            Mock<IPgdConditionsCmsReader> cmsReaderMock = new Mock<IPgdConditionsCmsReader>();
            cmsReaderMock.Setup(x => x.GetAllConditionByListingPageId(It.IsAny<int>()))
                .Returns(Data.CmsData.FullList);

            this.refReader = refReaderMock.Object;
            this.cmsReader = cmsReaderMock.Object;

            this.modelCreator = new PgdListingModelCreator(this.refReader, this.cmsReader);
        }
    }
}
