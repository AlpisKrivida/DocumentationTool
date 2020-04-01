﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using DocumentationTool.Client.Helpers;
using DocumentationTool.Client.Repository;
using DocumentationTool.Client.Repository.Hardware;

namespace DocumentationTool.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            ConfigureServices(builder.Services);

            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            services.AddScoped<IHttpService, HttpService>();
            services.AddScoped<IMouseRepository, MouseRepository>();
            services.AddScoped<IMonitorRepository, MonitorRepository>();
            services.AddScoped<IPrinterRepository, PrinterRepository>();
            services.AddScoped<IRouterRepository, RouterRepository>();
            services.AddScoped<IServerRepository, ServerRepository>();
        }
    }
}