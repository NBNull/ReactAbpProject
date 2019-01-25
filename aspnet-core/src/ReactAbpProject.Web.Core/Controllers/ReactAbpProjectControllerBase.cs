using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ReactAbpProject.Controllers
{
    public abstract class ReactAbpProjectControllerBase: AbpController
    {
        protected ReactAbpProjectControllerBase()
        {
            LocalizationSourceName = ReactAbpProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
