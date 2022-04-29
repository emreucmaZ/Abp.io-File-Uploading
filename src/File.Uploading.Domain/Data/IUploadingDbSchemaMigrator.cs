using System.Threading.Tasks;

namespace File.Uploading.Data;

public interface IUploadingDbSchemaMigrator
{
    Task MigrateAsync();
}
