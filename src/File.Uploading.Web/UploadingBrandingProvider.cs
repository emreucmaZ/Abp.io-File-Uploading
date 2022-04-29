using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace File.Uploading.Web;

[Dependency(ReplaceServices = true)]
public class UploadingBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Uploading";
}
