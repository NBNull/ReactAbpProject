using System.Threading.Tasks;
using Abp.Application.Services;
using ReactAbpProject.Authorization.Accounts.Dto;

namespace ReactAbpProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
