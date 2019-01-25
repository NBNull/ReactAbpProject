using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ReactAbpProject.Configuration.Dto;

namespace ReactAbpProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ReactAbpProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
