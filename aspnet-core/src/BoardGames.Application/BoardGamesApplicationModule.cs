using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BoardGames.Authorization;

namespace BoardGames
{
    [DependsOn(
        typeof(BoardGamesCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BoardGamesApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<BoardGamesAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(BoardGamesApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
