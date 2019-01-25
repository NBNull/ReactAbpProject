using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ReactAbpProject.Configuration;

namespace ReactAbpProject.Web.Host.Startup
{
    [DependsOn(
       typeof(ReactAbpProjectWebCoreModule))]
    public class ReactAbpProjectWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ReactAbpProjectWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ReactAbpProjectWebHostModule).GetAssembly());
        }
    }
}
