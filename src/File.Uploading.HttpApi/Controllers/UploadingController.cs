using File.Uploading.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace File.Uploading.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class UploadingController : AbpControllerBase
{
    protected UploadingController()
    {
        LocalizationResource = typeof(UploadingResource);
    }
}
