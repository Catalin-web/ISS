using Frontend.Views.Pages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Frontend.Views
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            var services = host.Services;

            Application.Run(services.GetRequiredService<FirstPage>());
        }

        public static IHostBuilder CreateHostBuilder()
        {
            // Use Startup class
            return Host.CreateDefaultBuilder()
                .ConfigureServices((_, services) =>
                {
                    services.ConfigureServices();
                });
                
        }
    }
}
