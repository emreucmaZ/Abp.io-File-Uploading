using File.Uploading.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace File.Uploading.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class UploadingPageModel : AbpPageModel
{
    protected UploadingPageModel()
    {
        LocalizationResourceType = typeof(UploadingResource);
    }
}
