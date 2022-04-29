using File.Uploading.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace File.Uploading.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(UploadingEntityFrameworkCoreModule),
    typeof(UploadingApplicationContractsModule)
    )]
public class UploadingDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
