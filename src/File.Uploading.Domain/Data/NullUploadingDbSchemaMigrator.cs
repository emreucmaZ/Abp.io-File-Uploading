using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace File.Uploading.Data;

/* This is used if database provider does't define
 * IUploadingDbSchemaMigrator implementation.
 */
public class NullUploadingDbSchemaMigrator : IUploadingDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
