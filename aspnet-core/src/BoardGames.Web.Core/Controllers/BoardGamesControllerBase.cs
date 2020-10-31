using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace BoardGames.Controllers
{
    public abstract class BoardGamesControllerBase: AbpController
    {
        protected BoardGamesControllerBase()
        {
            LocalizationSourceName = BoardGamesConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
