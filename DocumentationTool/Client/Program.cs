using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Syncfusion.Blazor;
using System.Text;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using DocumentationTool.Client.Helpers;
using DocumentationTool.Client.Repository;
using DocumentationTool.Client.Repository.Hardware;
using DocumentationTool.Client.Repository.Infrastucture;
using DocumentationTool.Client.Repository.Software;
using System.Security;
using DocumentationTool.Client.Repository.Contacts;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.AspNetCore.Http;
using DocumentationTool.Client.Repository.Sowftware;
using DocumentationTool.Client.Repository.Shared;

namespace DocumentationTool.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider
                 .RegisterLicense("MjU1NDcwQDMxMzgyZTMxMmUzMGk0bUFPSG5XMTBWTTNCWThOUFE4Wnh0aHRWT29SOXZlSFh4YUFma0hWd0U9");

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            ConfigureServices(builder.Services);

            builder.Services.AddSyncfusionBlazor();
            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IHttpService, HttpService>();
            services.AddScoped<IMouseRepository, MouseRepository>();
            services.AddScoped<IMonitorRepository, MonitorRepository>();
            services.AddScoped<IPrinterRepository, PrinterRepository>();
            services.AddScoped<IPersonRepostiroy, PersonRepository>();
            services.AddScoped<IRouterRepository, RouterRepository>();
            services.AddScoped<IServerRepository, ServerRepository>();
            services.AddScoped<ISwitchRepository, SwitchRepository>();
            services.AddScoped<ICableRepository, CableRepostitory>();
            services.AddScoped<IClientRepository, ClientRepository>();
 

            //Software
            services.AddScoped<IApplicationRepository, ApplicationRepository>();
            services.AddScoped<ILicenseRepository, LicenseRepository>();

            //Shared
            services.AddScoped<IPortRepository, PortRepository>();
        }
    }
}
