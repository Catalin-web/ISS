using System.Globalization;

namespace Server.WebApi.Settings
{
    public class EnvironmentVariablesSettingsProvider : ISettingsProvider
    {
        public string BindingAddress
        {
            get
            {
                return Environment.GetEnvironmentVariable("AUTH_BINDING_ADRESS") ?? "http://localhost";
            }
        }

        public int Port
        {
            get
            {
                return int.Parse(Environment.GetEnvironmentVariable("AUTH_PORT") ?? "12500", CultureInfo.InvariantCulture);
            }
        }

        public string ConnectionString
        {
            get
            {
                return Environment.GetEnvironmentVariable("AUTH_CONNECTION_STRING") ?? "mongodb://localhost:27017";
            }
        }
    }
}
