using Accessibility;
using Frontend.Client;
using Frontend.Views.Pages;
using Microsoft.Extensions.DependencyInjection;

namespace Frontend.Views
{
    public static class Startup
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            var settingsProvider = SettingsProviderFactory.Create();

            // Configure Clients:
            services.ConfigureCard(settingsProvider)
                .ConfigureCard(settingsProvider)
                .ConfigureCinema(settingsProvider)
                .ConfigureMovie(settingsProvider)
                .ConfigureProjection(settingsProvider)
                .ConfigureReservation(settingsProvider)
                .ConfigureTicket(settingsProvider)
                .ConfigureUser(settingsProvider);

            // Configure Pages:
            services.ConfigurePages();
        }

        private static IServiceCollection ConfigureCard(this IServiceCollection services, ISettingsProvider settingsProvider)
        {
            var cardClient = new CardClient(settingsProvider.CardBaseUrl);
            services.AddSingleton<ICardClient>(cardClient);
            return services;
        }
        private static IServiceCollection ConfigureCinema(this IServiceCollection services, ISettingsProvider settingsProvider)
        {
            var cinemaClient = new CinemaClient(settingsProvider.CinemaBaseUrl);
            services.AddSingleton<ICinemaClient>(cinemaClient);
            return services;
        }

        private static IServiceCollection ConfigureMovie(this IServiceCollection services, ISettingsProvider settingsProvider)
        {
            var movieClient = new MovieClient(settingsProvider.MovieBaseUrl);
            services.AddSingleton<IMovieClient>(movieClient);
            return services;
        }

        private static IServiceCollection ConfigureProjection(this IServiceCollection services, ISettingsProvider settingsProvider)
        {
            var projectionClient = new ProjectionClient(settingsProvider.ProjectionBaseUrl);
            services.AddSingleton<IProjectionClient>(projectionClient);
            return services;
        }

        private static IServiceCollection ConfigureReservation(this IServiceCollection services, ISettingsProvider settingsProvider) 
        {
            var reservationClient = new ReservationClient(settingsProvider.ReservationBaseUrl);
            services.AddSingleton<IReservationClient>(reservationClient);
            return services;
        }

        private static IServiceCollection ConfigureTicket(this IServiceCollection services, ISettingsProvider settingsProvider)
        {
            var ticketClient = new TicketClient(settingsProvider.TicketBaseUrl);
            services.AddSingleton<ITicketClient>(ticketClient);
            return services;
        }

        private static IServiceCollection ConfigureUser(this IServiceCollection services, ISettingsProvider settingsProvider)
        {
            var userClient = new UserClient(settingsProvider.UserBaseUrl);
            services.AddSingleton<IUserClient>(userClient);
            return services;
        }

        private static IServiceCollection ConfigurePages(this IServiceCollection services)
        {
            services.AddTransient<FirstPage>();
            services.AddTransient<Register>();
            services.AddTransient<Login>();
            services.AddTransient<CreateCardPopup>();
            services.AddTransient<ReservatePopup>();
            services.AddTransient<BuyTicketPopup>();
            services.AddTransient<ShowAllTicketsPopup>();
            services.AddTransient<ShowAllReservationsPopup>();
            services.AddTransient<ClientMainPage>();

            // Admin:
            services.AddTransient<AddMoviePage>();
            services.AddTransient<AddCinemaPage>();
            services.AddTransient<AddProjectionPage>();
            services.AddTransient<DeleteReservationPage>();
            services.AddTransient<AdminMainPage>();
            return services;
        }
    }
}
