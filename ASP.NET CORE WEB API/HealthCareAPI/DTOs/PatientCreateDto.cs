namespace HealthCareAPI.DTOs
{
    public class PatientCreateDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
    }
}
