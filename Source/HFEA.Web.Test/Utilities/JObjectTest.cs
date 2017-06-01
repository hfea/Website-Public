using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HFEA.BL;

namespace HFEA.Web.Test.Utilities
{
    [TestClass]
    public class JObjectTest
    {
        [TestMethod]
        public void JObjectValueByPathReturned()
        {
            JObject jsonObject = JObject.Parse(@"{
              'Title': 'Some title',
              'value': { 'node' : { 'id' : 4,  'text' : 'some text' }  }
            }");

            string value = jsonObject.GetStringValueOrEmpty("value", "node", "id");

            Assert.IsTrue(value == "4");
        }

        [TestMethod]
        public void JTokenValueByPathReturned()
        {
            JObject jsonObject = JObject.Parse(@"{
              'Title': 'Some title',
              'value': { 'node' : { 'id' : 4,  'text' : 'some text' }  }
            }");

            JToken token = jsonObject["value"];
            
            string value = token.GetStringValueOrEmpty("node", "id");

            Assert.IsTrue(value == "4");
        }
    }
}
