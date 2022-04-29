using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using File.Uploading.Data;
using Volo.Abp.DependencyInjection;

namespace File.Uploading.EntityFrameworkCore;

public class EntityFrameworkCoreUploadingDbSchemaMigrator
    : IUploadingDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreUploadingDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the UploadingDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<UploadingDbContext>()
            .Database
            .MigrateAsync();
    }
}
