using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace File.Uploading;

public class UploadingWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<UploadingWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
