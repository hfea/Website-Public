using HFEA.Connector.Contracts.BlobUpload;
using HFEA.Connector.Contracts.OnlineApps;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Clients.OnlineApps
{
    public interface IOnlineAppsWriterClient
    {
        Task<bool> SaveFormData(UserControl control, Guid documentId);

        Task<bool> DeleteApplication(Guid userAppId);

        Task<bool> SubmitApplication(Guid userAppId);

        Task<UserApplication> InsertUserApplication(int appId);

        Task<BlobFileInfo> UploadOnlineAppFile(string fileName, int controlId, Stream stream);
    }
}
