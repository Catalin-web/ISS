using Frontend.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Frontend
{
    public static class Startup
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            var settingsProvider = SettingsProviderFactory.Create();
        }

        private static void ConfigureCard(this IServiceCollection services, ISettingsProvider settingsProvider)
        {
            var cardClient = new CardClient(settingsProvider.CardBaseUrl);
        }
    }
}
