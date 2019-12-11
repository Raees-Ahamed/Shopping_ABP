using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Shopping_Card.Configuration;

namespace Shopping_Card.Web.Host.Startup
{
    [DependsOn(
       typeof(Shopping_CardWebCoreModule))]
    public class Shopping_CardWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public Shopping_CardWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Shopping_CardWebHostModule).GetAssembly());
        }
    }
}
