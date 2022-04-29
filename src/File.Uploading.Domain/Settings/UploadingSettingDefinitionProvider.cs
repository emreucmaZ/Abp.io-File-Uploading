using Volo.Abp.Settings;

namespace File.Uploading.Settings;

public class UploadingSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(UploadingSettings.MySetting1));
    }
}
