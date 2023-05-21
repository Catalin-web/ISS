namespace Frontend.Views
{
    public interface ISettingsProvider
    {
        string CardBaseUrl { get; }
        string CinemaBaseUrl { get; }
        string MovieBaseUrl { get; } 
        string ProjectionBaseUrl { get; }
        string ReservationBaseUrl { get; }
        string TicketBaseUrl { get; }
        string UserBaseUrl { get; }
    }
}
