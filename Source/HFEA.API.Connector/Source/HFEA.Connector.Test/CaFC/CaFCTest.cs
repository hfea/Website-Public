using HFEA.Connector.Contracts.CaFC;
using HFEA.Connector.Service.ClientFactories;
using HFEA.Connector.Service.Clients.CaFC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HFEA.Connector.Test
{
    [TestClass]
    public class CaFCTest
    {   
        ClinicSearch client;

        [TestMethod]
        public void BaseClientExecuted()
        {
            Assert.IsNotNull(this.client);

            var results = client.GetClinicList();

            Assert.IsNotNull(results);
            Assert.IsInstanceOfType(results, typeof(SearchResults));
        }

        [TestMethod]
        public void BaseClientReturnsJSON()
        {
            Assert.IsNotNull(this.client);

            var results = client.GetAllClinicListJSON();

            Assert.IsFalse(string.IsNullOrEmpty(results));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsExceptionIfNoApiClient()
        {
            var client = new ClinicSearch(null);
        }

        [TestMethod]
        public void IsSearchTermsFromApiNotEmpty()
        {
            var results = client.GetSearchTerms();

            Assert.IsNotNull(results);
            Assert.IsTrue(results.CollectionNames.Any());
        }

        [TestMethod]
        public void CorrectSearchParamatersSentToAPI()
        {
            string place = "Moorgate, London";
            int distance = 50;
            char firstChar = '\0';
            List<int> options = new List<int>() { 0, 0 };
            int pageSize = 5;
            int page = 2;
            int sort = 1;

            SearchResults result = this.client.GetClinicList(place, distance, firstChar, options, pageSize, page, sort);

            var returned = result.SubmittedSearchParameters;
            string[] returnedOptions = returned.Options != null ? returned.Options.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries) : new string[0];

            Assert.IsTrue(
                returned.Source == place
                && returned.Radius == distance.ToString()
                && options.All(x => returnedOptions.Contains(x.ToString()) && returnedOptions.Length == options.Count)
                && returned.PageSize == pageSize.ToString()
                && returned.PageNumber == page.ToString()
                && returned.Sort == sort.ToString());
        }

        [TestInitialize]
        public void Init()
        {
            IocInit.Init();
            var factory = new ApiGetClientFactory(string.Empty);
            this.client = new ClinicSearch(factory);
        }
    }
}
