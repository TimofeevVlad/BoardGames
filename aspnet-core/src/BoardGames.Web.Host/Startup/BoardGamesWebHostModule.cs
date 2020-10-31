using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BoardGames.Configuration;

namespace BoardGames.Web.Host.Startup
{
    [DependsOn(
       typeof(BoardGamesWebCoreModule))]
    public class BoardGamesWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public BoardGamesWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoardGamesWebHostModule).GetAssembly());
        }
    }
}
