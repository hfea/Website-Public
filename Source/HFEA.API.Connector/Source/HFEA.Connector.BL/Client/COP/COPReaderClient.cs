using HFEA.Connector.Contracts.Clients.COP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.Connector.Contracts.COP;
using HFEA.Connector.Service.Clients;
using HFEA.Connector.Contracts.ClientFactories;
using System.Collections.Specialized;

namespace HFEA.Connector.Service.Client.COP
{
    public class COPReaderClient : BaseGetClient, ICOPReaderClient
    {
        protected const Constants.ApiType.ReferenceData GroupsApi = Constants.ApiType.ReferenceData.GetCop;
        protected const Constants.ApiType.ReferenceData SectionApi = Constants.ApiType.ReferenceData.GetCopSection;

        public COPReaderClient(IGetClientFactory factory) : base(factory)
        {
        }

        public virtual COPItem GetAllGroups()
        {
            return this.Factory.GetApiClient(GroupsApi).ExecuteRequest<COPItem>();
        }

        public virtual COPItem GetSection(int sectionId)
        {
            var parameters = this.GetSectionUrlParameters(sectionId);


            COPItem copItem = new COPItem();
            var tmp2 = this.Factory.GetApiClient(SectionApi).ExecuteRequest<object>(null, parameters);
          //try
//            {
                copItem = this.Factory.GetApiClient(SectionApi).ExecuteRequest<COPItem>(null, parameters);
            //}
            //catch (Exception e) {

            //}
            return copItem;
        }

        protected NameValueCollection GetSectionUrlParameters(int sectionId)
        {
            var parameters = new NameValueCollection();
            parameters.Add(Constants.ApiParams.Id, sectionId.ToString());

            return parameters;
        }
    }
}
