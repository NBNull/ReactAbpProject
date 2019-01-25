using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ReactAbpProject.Authorization;

namespace ReactAbpProject
{
    [DependsOn(
        typeof(ReactAbpProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ReactAbpProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ReactAbpProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ReactAbpProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
