using HFEA.Connector.Contracts.Constants;
using HFEA.Connector.Contracts.Users;
using HFEA.Connector.Service.ClientFactories;
using HFEA.Connector.Service.Clients.AccessControl;
using HFEA.Connector.Service.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HFEA.Connector.Test.AccessControl
{
    [TestClass]
    public class AccessControlWriterTest : SDKTestBase
    {
        private const ApiType.Centre ListApi = ApiType.Centre.GetPortalClinicUserList;

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsExceptionIfNoFactoryProvided()
        {
            var client = new ClinicUserWriter(null, this.Logger);
        }

        [TestMethod]
        [Ignore]
        public void IsNewUserCreated()
        {
            var client = new ClinicUserWriter(this.TokenResolver, this.Logger);

            var user = this.GetNewUserObject();

            string userId;
            bool result = client.Create(user, out userId);

            Assert.IsTrue(result);
            Assert.IsTrue(!string.IsNullOrEmpty(userId));
        }

        [TestMethod]
        [Ignore]
        public void IsUserDeleted()
        {
            string userId;
            var client = new ClinicUserWriter(this.TokenResolver, this.Logger);

            var user = this.GetNewUserObject();
                        
            bool result = client.Create(user, out userId);

            Assert.IsTrue(result);

            var readUser = this.Client.GetUser(userId);
            
            Assert.IsNotNull(readUser);
            Assert.IsTrue(readUser.IsEnabled);
            Assert.IsTrue(client.Delete(new Guid(userId)));

            var readUserAgain = this.Client.GetUser(userId);
            Assert.IsNull(readUserAgain);
        }

        //[TestMethod]
        //public void IsNewUserUnlocked()
        //{
        //    var client = new ClinicUserWriter(this.TokenResolver);

        //    string userId;
        //    bool result = client.Unlock(user, out userId);

        //    Assert.IsTrue(result);
        //    Assert.IsTrue(!string.IsNullOrEmpty(userId));
        //}

        //[TestMethod]
        //public void IsNewUserPasswordReset()
        //{
        //    var client = new ClinicUserWriter(this.TokenResolver);

        //    string userId;
        //    bool result = client.Unlock(user, out userId);

        //    Assert.IsTrue(result);
        //    Assert.IsTrue(!string.IsNullOrEmpty(userId));
        //}

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
               new SecurityRole {KnownName = Security.KnownRole.User, DisplayName = "Generic User"}
            };

            return user;
        }
    }
}
