using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.Clients.Centres;
using HFEA.Connector.Service.Clients;
using System.Collections.Specialized;

namespace HFEA.Connector.Service.Client.Various
{
    public class BlobUploadClient : BasePostClient, ICentreImageUpdateClient
    {
        private const string UploadType = "Profile";

        public BlobUploadClient(IPostClientFactory factory) : base(factory)
        { }

        public bool UpdateImage(int centreId,string contentMimeType, byte[] data)
        {
            var parameters = new NameValueCollection();
            parameters.Add(Constants.ApiParams.Id, centreId.ToString());
            parameters.Add(Constants.ApiParams.ImageType, UploadType);

            string fileName = centreId.ToString();

            return this.Factory.GetApiClient(Constants.ApiType.BlobUpload.UploadImage).UploadData(data, fileName,contentMimeType, parameters, null);
        }
    }
}
