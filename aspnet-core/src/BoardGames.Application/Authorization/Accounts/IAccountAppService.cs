using System.Threading.Tasks;
using Abp.Application.Services;
using BoardGames.Authorization.Accounts.Dto;

namespace BoardGames.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
