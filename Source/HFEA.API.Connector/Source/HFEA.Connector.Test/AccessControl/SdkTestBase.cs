using HFEA.Connector.Global;
using HFEA.SDK;
using HFEA.SDK.Model;
using Microsoft.Experimental.IdentityModel.Clients.ActiveDirectory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Test.AccessControl
{
    [TestClass]
    public class SDKTestBase
    {
        //private Uri _apiUri;
        //private string _tenantId;
        //private string _clientId;
        //private string _remoteResourceId;
        //private string _username;
        //private string _password;
        private IfqApiClient _client;

        private const string ApiSecret = "yourApiSecret";

        [TestInitialize]
        public virtual void SetUp()
        {   
            Connector.Service.AutoMapperInit.Init();

           

        Mock<ITokenResolver> mock = new Mock<ITokenResolver>();
            mock.Setup(x => x.GetJwtToken()).Returns(() =>
            {
                string token = "";
                try
                {
                    token = Client.JwtToken;
                }
                catch { }

                return token;
            });

            this.TokenResolver = mock.Object;

            try
            {
                this.LoggedInUser = this.Client?.GetMyUser();
                this.CurrentCentreId = int.Parse(this.LoggedInUser?.CentreId);
            }
            catch { }
        }

        protected ITokenResolver TokenResolver
        {
            get; private set;
        }

        protected User LoggedInUser { get; private set; }  

        protected int CurrentCentreId { get; private set; }

        protected IfqApiClient Client
        {
            get
            {
                if (_client == null)
                {                    
                    _client = new IfqApiClient(new Uri("http://somewebapi.azurewebsites.net"));

                    try
                    {
                        _client.AuthenticateBasic("name", ApiSecret);
                    }
                    catch { }
                }

                return _client;
            }
        }

        protected IHfeaLogger Logger
        {
            get
            {
                Mock<IHfeaLogger> logger = new Mock<IHfeaLogger>();
                return logger.Object;
            }
        }
    }
}
