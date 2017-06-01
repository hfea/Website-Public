using HFEA.Connector.Contracts.Client;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Global;
using HFEA.Connector.Contracts.Users;
using HFEA.Connector.Service.BaseClient;
using HFEA.Connector.Service.Clients.Users;
using HFEA.Connector.Service.ClientFactories;
using HFEA.Connector.Service.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Test
{
    [TestClass]
    public class UserApiClientTest
    {
        private const string Token = "my security token";
        private readonly static List<User> userList = new List<User>()
        {
            new User() { Id = "1" },
            new User() { Id = "2" }
        };

        IGetSecuredClientFactory clientFactory;

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullReferenceThrownIfFactoryIsNull()
        {
            var client = new UserClient(null);
        }

        [TestMethod]
        public void UserListReturned()
        {
            var client = new UserClient(clientFactory);
            var results = client.GetAllUserList();

            Assert.AreSame(userList, results);
        }

        [TestInitialize]
        public void Init()
        {
            //Mock<ITokenResolver> mockToken = new Mock<ITokenResolver>();
            //mockToken.Setup(x => x.GetJwtToken()).Returns(Token);
            //var factory = new SecuredApiClientFactory(mockToken.Object);

            Mock<IApiGetClient> mockClient = new Mock<IApiGetClient>();
            mockClient.Setup(x => x.ExecuteRequest<List<User>>()).Returns(userList);

            Mock<IGetSecuredClientFactory> mockFactory = new Mock<IGetSecuredClientFactory>();
            mockFactory.Setup(x => x.GetApiClient(ApiType.Security.GetUserList)).Returns(mockClient.Object);
            this.clientFactory = mockFactory.Object;

         }

    }
}
