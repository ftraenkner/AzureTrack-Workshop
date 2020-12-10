using System;

using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Sas;

using Microsoft.Extensions.Options;

using RMotownFestival.Api.Options;

namespace RMotownFestival.Api.Common
{
    public class BlobUtility
    {
        private readonly StorageSharedKeyCredential _credential;
        private readonly BlobServiceClient _client;
        private readonly IOptions<BlobSettingsOptions> _options;

        public BlobUtility(StorageSharedKeyCredential credential, BlobServiceClient client, IOptions<BlobSettingsOptions> options)
        {
            _credential = credential;
            _client = client;
            _options = options;
        }

        public BlobContainerClient GetPicturesContainer()
        {
            return _client.GetBlobContainerClient(_options.Value.PicturesContainer);
        }

        public string GetSasUri(BlobContainerClient blobContainer, string blobName)
        {
            var blobSasBuilder = new BlobSasBuilder
            {
                BlobContainerName = blobContainer.Name,
                BlobName = blobName,
                Resource = "b",
                StartsOn = DateTimeOffset.UtcNow.AddMinutes(-1),
                ExpiresOn = DateTimeOffset.UtcNow.AddMinutes(2)
            };

            blobSasBuilder.SetPermissions(BlobAccountSasPermissions.Read);

            // ues the key to get the SAS token
            var sasToken = blobSasBuilder.ToSasQueryParameters(_credential).ToString();

            return $"{blobContainer.Uri.AbsoluteUri}/{blobName}?{sasToken}";
        }
    }
}
