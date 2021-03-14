using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using SPOS.Classes;
using System.Diagnostics;
using Microsoft.AspNetCore.Hosting.WindowsServices;
using System.Linq;

namespace SPOS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var isService = false;
            if (Debugger.IsAttached == false && args.Contains("--service"))
            {
                isService = true;
            }

            if (isService)
            {
                var pathToContentRoot = System.IO.Directory.GetCurrentDirectory();

                var pathToExe = Process.GetCurrentProcess().MainModule.FileName;
                pathToContentRoot = System.IO.Path.GetDirectoryName(pathToExe);

                var host = Microsoft.AspNetCore.WebHost.CreateDefaultBuilder(args)
                    .UseContentRoot(pathToContentRoot)
                    .UseStartup<Startup>()
                    .UseUrls("http://localhost:" + Configurations.GetConfiguration("ServicePort"))
                    .Build();

                host.RunAsService();
            }
            else
            {
                CreateHostBuilder(args).Build().Run();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
