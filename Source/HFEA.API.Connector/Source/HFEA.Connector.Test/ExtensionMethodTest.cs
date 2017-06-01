using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HFEA.Connector.Service.Extensions;
using HFEA.Connector.Service.Constants;
using HFEA.Connector.Contracts.Constants;
using HFEA.Connector.Service.Attributes;

namespace HFEA.Connector.Test
{
    [TestClass]
    public class ExtensionMethodTest
    {
        [TestMethod]
        public void IsEnumAttributeCallTypeObtained()
        {
            var value = ApiType.Security.GetGroupList;

            CallType attr = value.GetCallType();

            Assert.IsNotNull(attr);
            Assert.IsTrue(attr.Method == HttpMethod.GET);
            Assert.IsTrue(attr.RequiresAuthentication);
        }

        [TestMethod]
        public void AreEnumAttributeDescriptionObtained()
        {
            var value = ApiType.Security.CreateUser;

            string attr = value.GetDescription();

            Assert.IsNotNull(attr);
            Assert.IsTrue(attr == "/api/security/users");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetValueFromDescriptionThrowInvalidOperationExceptionIfTypeIsNotEnum()
        {
            AttributeReaderExtension.GetValueFromDescription<string>("description");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Not found")]
        public void GetValueFromDescriptionThrowArgumentExceptionExceptionIfDescriptionNotFound()
        {
            AttributeReaderExtension.GetValueFromDescription<Centre.RagPriority>("Black");
            
        }

        [TestMethod]
        public void GetValueFromDescriptionReturnEnumValue()
        {
            var value = AttributeReaderExtension.GetValueFromDescription<Centre.RagPriority>("None");
            Assert.AreEqual(value.ToString(), "None");

        }
    }
}
