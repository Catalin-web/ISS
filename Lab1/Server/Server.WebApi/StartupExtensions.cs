using Microsoft.OpenApi.Models;
using Server.DataStore;
using Server.WebApi.Settings;

namespace Server.WebApi
{
    internal static class StartupExtensions
    {
        public static ISettingsProvider SetupSettings(this IServiceCollection services)
        {
            ISettingsProvider settingsProvider = SettingsProviderFactory.Create();
            services.AddSingleton<ISettingsProvider>(settingsProvider);
            return settingsProvider;
        }

        public static IServiceCollection SetupSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "1",
                    Title = "Cinema Service",
                    Description = "This is the cinema Service.",
                    Contact = new OpenApiContact
                    {
                        Name = "Catalin",
                        Email = "catalinbgnr@gmail.com"
                    }
                });
            });
            return services;
        }

        public static IServiceCollection SetupDataContext(this IServiceCollection services, ISettingsProvider settingsProvider)
        {
            var mongoDataContext = new MongoDataContext(settingsProvider.ConnectionString);
            services.AddSingleton<IMongoDataContext>(mongoDataContext);
            return services;
        }

        public static IServiceCollection SetupDatabase(this IServiceCollection services)
        {
            services.AddSingleton<ICardDataProvider, CardDataProvider>();
            services.AddSingleton<ICinemaDataProvider, CinemaDataProvider>();
            services.AddSingleton<IMovieDataProvider, MovieDataProvider>();
            services.AddSingleton<IProjectionDataProvider, ProjectionDataProvider>();
            services.AddSingleton<IReservationDataProvider, ReservationDataProvider>();
            services.AddSingleton<ITicketDataProvider, TicketDataProvider>();
            services.AddSingleton<IUserDataProvider, UserDataProvider>();
            return services;
        }

        public static IServiceCollection SetupServices(this IServiceCollection services)
        {
            services.AddSingleton<ICardFacade, CardFacade>();
            services.AddSingleton<ICinemaFacade, CinemaFacade>();
            services.AddSingleton<IMovieFacade, MovieFacade>();
            services.AddSingleton<IProjectionFacade, ProjectionFacade>();
            services.AddSingleton<IReservationFacade, ReservationFacade>();
            services.AddSingleton<ITicketFacade, TicketFacade>();
            services.AddSingleton<IUserFacade, UserFacade>();
            return services;
        }
    }
}
