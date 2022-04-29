using System;
using System.Collections.Generic;
using System.Text;
using File.Uploading.Localization;
using Volo.Abp.Application.Services;

namespace File.Uploading;

/* Inherit your application services from this class.
 */
public abstract class UploadingAppService : ApplicationService
{
    protected UploadingAppService()
    {
        LocalizationResource = typeof(UploadingResource);
    }
}
