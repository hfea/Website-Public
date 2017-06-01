
using AutoMapper;
using HFEA.Connector.Contracts.Client.Users;
using HFEA.Connector.Contracts.Clients.AccessControl;
using HFEA.Connector.Contracts.Constants;
using HFEA.Connector.Service.ClientFactories;
using HFEA.Connector.Service.Clients.AccessControl;
using HFEA.Connector.Service.Constants;
using HFEA.Connector.Service.Utilities;
using HFEA.SDK.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HFEA.Connector.Test.AccessControl
{
    [TestClass]
    public class AccessControlUpdaterTest : SDKTestBase
    {
        private IUserReader readClient;
        private IClinicUserWriter writeClient;

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsExceptionIfNoReadClientProvided()
        {
            var client = new UserObjectSaveUtility(this.readClient, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsExceptionIfWriteClientProvided()
        {
            var client = new UserObjectSaveUtility(null, this.writeClient);
        }

        [TestMethod]
        [Ignore]
        public void IsUserUpdated()
        {
            var util = new UserObjectSaveUtility(this.readClient, this.writeClient);

            var user = this.GetNewUserObject();
            user = this.Client.CreateUser(user);

            Assert.IsTrue(!string.IsNullOrEmpty(user.Id));

            var mappedUser = Mapper.Map<Contracts.Users.User>(user);
            mappedUser.FirstName = "UNIT TEST";
            mappedUser.EmailAddress = "unittest@mail.com";

            Assert.IsTrue(util.UpdateUser(mappedUser));

            var readUser = this.Client.GetUser(mappedUser.Id);
            Assert.IsNotNull(readUser);
            Assert.IsTrue(readUser.FirstName == mappedUser.FirstName);
            Assert.IsTrue(readUser.EmailAddress == mappedUser.EmailAddress);
        }

        [TestInitialize]
        public void Init()
        {
            Mock<IUserReader> readerMock = new Mock<IUserReader>();
            readerMock
                .Setup(x => x.GetUser(It.IsAny<string>()))
                .Returns<string>((id) => 
                {
                    var usr = this.Client.GetUser(id);
                    return Mapper.Map<Contracts.Users.User>(usr);                    
                });

            this.readClient = readerMock.Object;

            this.writeClient = new ClinicUserWriter(this.TokenResolver, this.Logger);
        }
       
        private User GetNewUserObject()
        {
            string id = string.Format("ID-{0}", Guid.NewGuid());

            var user = new User();
            user.CentreId = this.CurrentCentreId.ToString();
            user.FirstName = "RR";
            user.LastName = "NUnit TEST";
            user.PrincipalName = id;
            user.DisplayName = "RR NUnit TEST";
            user.EmailAddress = id + "@gmail.com";
            user.IsEnabled = true;
            user.Roles = new List<SecurityRole>
            {
               new SecurityRole {KnownName = KnownRole.User, DisplayName = "Generic User"}
            };

            return user;
        }
    }
}
