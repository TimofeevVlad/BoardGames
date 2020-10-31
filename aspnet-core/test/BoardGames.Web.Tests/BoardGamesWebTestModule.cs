using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BoardGames.EntityFrameworkCore;
using BoardGames.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace BoardGames.Web.Tests
{
    [DependsOn(
        typeof(BoardGamesWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class BoardGamesWebTestModule : AbpModule
    {
        public BoardGamesWebTestModule(BoardGamesEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoardGamesWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(BoardGamesWebMvcModule).Assembly);
        }
    }
}