using HFEA.Connector.Contracts.OnlineApps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Clients.OnlineApps
{
    public interface IOnlineAppsReaderClient
    {
        Task<List<Application>> GetAllApplicationInfo();
        Task<List<UserApplication>> GetAllCentreApplications();
        Task<List<UserApplication>> GetCentreSubmittedApplications();
        Task<List<UserApplication>> GetCentreCompletedApplications();
        Task<List<UserApplication>> GetCentreEditingApplications();
        Task<UserApplication> GetUserApplicationByAppId(int id);
        Task<UserApplication> GetUserApplicationByUserAppId(Guid id);
        Task<ApplicationDocumentControl> GetFirstPage(Guid documentId);
        Task<ApplicationDocumentControl> GetPageById(int pageId, Guid documentId);
        Task<ApplicationDocumentControl> GetNextPage(int currentPageId, Guid documentId);
        Task<ApplicationDocumentControl> GetPreviousPage(int currentPageId, Guid documentId);
        Task<ApplicationDocumentControl> JumpToPage(int currentPageId, Guid documentId, int distanceFromCurrent);
        Task<UserControl> GetPageData(int pageId, Guid documentId);
        Task<List<ApplicationDocumentControl>> GetDocumentValidation(Guid documentId);
        Task<List<ApplicationDocumentControlValidation>> GetPageValidation(int pageId);
        Task<byte[]> GetFileBytes(string blobName);
    }
}
