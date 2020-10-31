using Abp.Application.Services;
using BoardGames.MultiTenancy.Dto;

namespace BoardGames.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

