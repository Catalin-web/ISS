using Server.WebApi.Settings;

namespace Server.WebApi
{
    public class SettingsProviderFactory
    {
        public static ISettingsProvider Create()
        {
            return new EnvironmentVariablesSettingsProvider();
        }
    }
}
