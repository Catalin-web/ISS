using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;

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

            // Application.Run(services.GetRequiredService<Form1>());
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
