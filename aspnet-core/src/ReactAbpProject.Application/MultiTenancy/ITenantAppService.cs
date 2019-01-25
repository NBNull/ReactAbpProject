using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ReactAbpProject.MultiTenancy.Dto;

namespace ReactAbpProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

