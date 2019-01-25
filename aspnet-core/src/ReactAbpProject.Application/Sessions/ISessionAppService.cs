using System.Threading.Tasks;
using Abp.Application.Services;
using ReactAbpProject.Sessions.Dto;

namespace ReactAbpProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
