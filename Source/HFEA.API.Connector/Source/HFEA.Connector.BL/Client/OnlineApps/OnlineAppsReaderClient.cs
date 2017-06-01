using AutoMapper;
using HFEA.Connector.Contracts.Centre;
using HFEA.Connector.Contracts.Clients.OnlineApps;
using HFEA.Connector.Contracts.OnlineApps;
using HFEA.Connector.Global;
using HFEA.Connector.Service.BaseClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HFEA.Connector.Service.Client.OnlineApps
{
    public class OnlineAppsReaderClient : BaseSdkClient, IOnlineAppsReaderClient
    {
        public OnlineAppsReaderClient(ITokenResolver tokenResolver, IHfeaLogger logger) : base(tokenResolver, logger)
        {
        }

        public virtual async Task<ApplicationDocumentControl> GetFirstPage(Guid documentId)
        {
            var res = await this.ApiClient.GetFirstPage(documentId.ToString());

            return Mapper.Map<ApplicationDocumentControl>(res);
        }

        public virtual async Task<ApplicationDocumentControl> GetNextPage(int currentPageId, Guid documentId)
        {
            var res = await this.ApiClient.GetNextPage(currentPageId.ToString(), documentId.ToString());

            return Mapper.Map<ApplicationDocumentControl>(res);
        }

        public virtual async Task<ApplicationDocumentControl> GetPreviousPage(int currentPageId, Guid documentId)
        {
            var res = await this.ApiClient.GetPreviousPage(currentPageId.ToString(), documentId.ToString());

            return Mapper.Map<ApplicationDocumentControl>(res);
        }

        public virtual async Task<ApplicationDocumentControl> JumpToPage(int currentPageId, Guid documentId, int distanceFromCurrent)
        {
            var res = await this.ApiClient.JumpToPage(currentPageId.ToString(), documentId.ToString(), distanceFromCurrent.ToString());

            return Mapper.Map<ApplicationDocumentControl>(res);
        }

        public virtual async Task<List<ApplicationDocumentControlValidation>> GetPageValidation(int pageId)
        {
            var validation = await this.ApiClient.GetPageValidation(pageId.ToString());

            return Mapper.Map<List<ApplicationDocumentControlValidation>>(validation);
        }

        public virtual async Task<UserApplication> GetUserApplicationByAppId(int id)
        {
            var apps = await this.GetAllCentreApplications();

            if (apps != null)
            {
                return apps.FirstOrDefault(x => x.ApplicationID == id);
            }

            return null;
        }

        public virtual async Task<UserApplication> GetUserApplicationByUserAppId(Guid id)
        {
            var app = await this.ApiClient.GetUserApplication(id.ToString());
            return Mapper.Map<UserApplication>(app);
        }

        public async Task<ApplicationDocumentControl> GetPageById(int pageId, Guid documentId)
        {
            return await JumpToPage(pageId, documentId, 0);
        }

        public async Task<UserControl> GetPageData(int pageId, Guid documentId)
        {
            var res = await this.ApiClient.GetPageData(pageId.ToString(), documentId.ToString());

            return Mapper.Map<UserControl>(res);
        }

        public async Task<List<UserApplication>> GetAllCentreApplications()
        {
            var apps = await this.ApiClient.GetAllCentreApplications();

            return (Mapper.Map<IEnumerable<UserApplication>>(apps)).ToList();
        }

        public async Task<List<UserApplication>> GetCentreSubmittedApplications()
        {
            var apps = await this.ApiClient.GetCentreSubmittedApplications();

            return (Mapper.Map<IEnumerable<UserApplication>>(apps)).ToList();
        }

        public async Task<List<UserApplication>> GetCentreCompletedApplications()
        {
            var apps = await this.ApiClient.GetCentreCompletedApplications();

            return (Mapper.Map<IEnumerable<UserApplication>>(apps)).ToList();
        }

        public async Task<List<UserApplication>> GetCentreEditingApplications()
        {
            var apps = await this.ApiClient.GetCentreEditingApplications();

            return (Mapper.Map<IEnumerable<UserApplication>>(apps)).ToList();
        }

        public async Task<List<ApplicationDocumentControl>> GetDocumentValidation(Guid documentId)
        {
            var apps = await this.ApiClient.GetValidation(documentId.ToString());

            return Mapper.Map<List<ApplicationDocumentControl>>(apps);
        }

        public async Task<List<Application>> GetAllApplicationInfo()
        {
            var apps = await this.ApiClient.GetApplicationMenu();

            return Mapper.Map<List<Application>>(apps);
        }  
        
        public async Task<byte[]> GetFileBytes(string blobName)
        {
            byte[] result = await this.ApiClient.DownloadFile(blobName);

            return result;
        }
    }
}
