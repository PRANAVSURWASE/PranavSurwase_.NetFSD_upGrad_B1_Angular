namespace FlightService.DTOs
{
    public class FlightDTO
    {
        public string FlightNumber { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public decimal Price { get; set; }
    }
}
