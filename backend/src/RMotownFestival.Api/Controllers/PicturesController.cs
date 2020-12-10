using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using RMotownFestival.Api.Common;

using System.Linq;

namespace RMotownFestival.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PicturesController : ControllerBase
    {
        private readonly BlobUtility _blobUtility;

        public PicturesController(BlobUtility blobUtility)
        {
            _blobUtility = blobUtility;
        }

        [HttpGet]
        public string[] GetAllPictureUrls()
        {
            var blobContainer = _blobUtility.GetPicturesContainer();

            return blobContainer.GetBlobs()
                .Select(blob => _blobUtility.GetSasUri(blobContainer, blob.Name))
                .ToArray();
        }

        [HttpPost]
        public void PostPicture(IFormFile file)
        {
            var blobContainer = _blobUtility.GetPicturesContainer();
            blobContainer.UploadBlob(file.FileName, file.OpenReadStream());
        }
    }
}
