namespace Frontend.Views
{
    public class EnvironmentVariablesSettingsProvider : ISettingsProvider
    {
        public string CardBaseUrl => "http://localhost:12500/card";

        public string CinemaBaseUrl => "http://localhost:12500/cinema";

        public string MovieBaseUrl => "http://localhost:12500/movie";

        public string ProjectionBaseUrl => "http://localhost:12500/projection";

        public string ReservationBaseUrl => "http://localhost:12500/reservation";

        public string TicketBaseUrl => "http://localhost:12500/ticket";

        public string UserBaseUrl => "http://localhost:12500/user";
    }
}
