using System.Threading.Tasks;
using ReactAbpProject.Configuration.Dto;

namespace ReactAbpProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
