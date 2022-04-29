using File.Uploading.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace File.Uploading.Permissions;

public class UploadingPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(UploadingPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(UploadingPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<UploadingResource>(name);
    }
}
