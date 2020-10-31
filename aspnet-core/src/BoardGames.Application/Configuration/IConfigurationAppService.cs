using System.Threading.Tasks;
using BoardGames.Configuration.Dto;

namespace BoardGames.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
