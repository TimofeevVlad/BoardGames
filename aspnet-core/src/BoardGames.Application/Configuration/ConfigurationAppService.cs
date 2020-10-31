using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using BoardGames.Configuration.Dto;

namespace BoardGames.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BoardGamesAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
