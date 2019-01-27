using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Runtime.Caching.Redis;
using ReactAbpProject.Authorization;

namespace ReactAbpProject
{
    [DependsOn(
        typeof(ReactAbpProjectCoreModule), 
        typeof(AbpAutoMapperModule),
        typeof(AbpRedisCacheModule))]
    public class ReactAbpProjectApplicationModule : AbpModule
    {
        ///模块生命周期

        /// <summary>
        /// 模块启动前
        /// </summary>
        public override void PreInitialize()
        {
            Configuration.MultiTenancy.IsEnabled = false;//关闭多租户
            Configuration.Caching.UseRedis(option=> {
                //option.ConnectionString = "redisPa$$w0rd@180.168.83.90:7944";
                option.ConnectionString = "localhost";
                option.DatabaseId = 0;
            });
            Configuration.Authorization.Providers.Add<ReactAbpProjectAuthorizationProvider>();
        }
        /// <summary>
        /// 模块初始化
        /// </summary>
        public override void Initialize()
        {
            var thisAssembly = typeof(ReactAbpProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
        /// <summary>
        /// 模块启动完成调用
        /// </summary>

        public override void PostInitialize()
        {
            base.PostInitialize();
        }
        /// <summary>
        /// 模块关闭时调用
        /// </summary>
        public override void Shutdown()
        {
            base.Shutdown();
        }
    }
}
