using Volo.Abp.Modularity;

namespace File.Uploading;

[DependsOn(
    typeof(UploadingApplicationModule),
    typeof(UploadingDomainTestModule)
    )]
public class UploadingApplicationTestModule : AbpModule
{

}
