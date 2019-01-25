using Abp.Authorization;
using ReactAbpProject.Authorization.Roles;
using ReactAbpProject.Authorization.Users;

namespace ReactAbpProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
