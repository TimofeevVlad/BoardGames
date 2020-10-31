using Abp.Authorization;
using BoardGames.Authorization.Roles;
using BoardGames.Authorization.Users;

namespace BoardGames.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
