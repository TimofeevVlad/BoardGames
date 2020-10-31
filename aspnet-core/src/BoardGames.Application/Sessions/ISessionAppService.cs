using System.Threading.Tasks;
using Abp.Application.Services;
using BoardGames.Sessions.Dto;

namespace BoardGames.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
