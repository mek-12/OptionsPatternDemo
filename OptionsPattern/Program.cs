using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using OptionsPattern.Factory;
using OptionsPattern.Properties;
using System;
namespace OptionsPattern {
    class Program {
        static void Main(string[] args) {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder();
            
            builder.Configuration.Sources.Clear();

            IHostEnvironment hostEnvironment = builder.Environment;
            var rootPath = hostEnvironment.ContentRootPath;
            var appsettingsPath = $"{rootPath}/appsettings.json";
            builder.Configuration.AddJsonFile(appsettingsPath, optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{hostEnvironment.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            VehicleInfo vehicleInfo = new();

            builder.Configuration.GetSection("VehicleInfo").Bind(vehicleInfo);
            builder.Services.Configure<VehicleInfo>(builder.Configuration.GetSection("VehicleInfo"));
            builder.Services.AddScoped<VehicleProvider>();
            App app = new(builder.Services.BuildServiceProvider().GetService<VehicleProvider>());
            app.StartTrip();
            
            using IHost host = builder.Build();
            host.Run();
            
        }

    }
}