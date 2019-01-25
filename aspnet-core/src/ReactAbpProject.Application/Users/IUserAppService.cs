using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ReactAbpProject.Roles.Dto;
using ReactAbpProject.Users.Dto;

namespace ReactAbpProject.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
