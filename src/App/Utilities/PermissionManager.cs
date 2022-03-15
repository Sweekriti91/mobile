using System.Threading.Tasks;


namespace Bit.App.Utilities
{
    public static class PermissionManager
    {
        public static async Task<PermissionStatus> CheckAndRequestPermissionAsync<T>(T permission)
            where T : Microsoft.Maui.Essentials.Permissions.BasePermission
        {
            var status = await permission.CheckStatusAsync();
            if (status != PermissionStatus.Granted)
            {
                status = await permission.RequestAsync();
            }

            return status;
        }
    }
}
