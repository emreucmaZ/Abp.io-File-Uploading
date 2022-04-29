using File.Uploading.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace File.Uploading;

[DependsOn(
    typeof(UploadingEntityFrameworkCoreTestModule)
    )]
public class UploadingDomainTestModule : AbpModule
{

}
