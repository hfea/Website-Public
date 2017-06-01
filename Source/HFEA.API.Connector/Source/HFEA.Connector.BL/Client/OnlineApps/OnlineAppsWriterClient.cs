using AutoMapper;
using HFEA.Connector.Contracts.BlobUpload;
using HFEA.Connector.Contracts.Clients.OnlineApps;
using HFEA.Connector.Contracts.OnlineApps;
using HFEA.Connector.Global;
using HFEA.Connector.Service.BaseClient;
using System;
using System.IO;
using System.Threading.Tasks;

namespace HFEA.Connector.Service.Client.OnlineApps
{
    public class OnlineAppsWriterClient : BaseSdkClient, IOnlineAppsWriterClient
    {
        public OnlineAppsWriterClient(ITokenResolver tokenResolver, IHfeaLogger logger) : base(tokenResolver, logger)
        {
        }

        public async Task<bool> DeleteApplication(Guid userAppId)
        {
            return await this.ApiClient.DeleteUserApplication(userAppId.ToString());
        }

        public async Task<bool> SubmitApplication(Guid userAppId)
        {
            return await this.ApiClient.SubmitUserApplication(userAppId.ToString());
        }

        public async Task<UserApplication> InsertUserApplication(int appId)
        {
            var app = await this.ApiClient.InsertActiveUserApplication(appId.ToString());

            return Mapper.Map<UserApplication>(app);
        }

        public async Task<bool> SaveFormData(UserControl control, Guid documentId)
        {
            var mappedControl = Mapper.Map<SDK.Model.UserControl>(control);
            return await this.ApiClient.SaveData(mappedControl, documentId.ToString());
        }

        public async Task<BlobFileInfo> UploadOnlineAppFile(string fileName, int controlId, Stream stream)
        {
            BlobFileInfo file = null;

            //fileName=fileName.Replace("\\","");
            //fileName = fileName.Replace("/", "");

            int pos=fileName.LastIndexOf("\\");
            if (pos>=0)
            {
                fileName = fileName.Substring(pos + 1, fileName.Length - pos - 1);
            }
            int pos1 = fileName.LastIndexOf("/");
            if (pos1 >= 0)
            {
                fileName = fileName.Substring(pos1 + 1, fileName.Length - pos1 - 1);
            }
            fileName = fileName.Replace(":", "");

            var blob = await this.ApiClient.UploadOlBlob(fileName, controlId, stream);
            if (blob != null)
            {
                file = new BlobFileInfo()
                {
                    FileName = blob.FileName,
                    FileSizeInBytes = blob.FileSizeInBytes,
                    FileUrl = blob.FileUrl
                };
            }

            return file;
        }
    }
}
