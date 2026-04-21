using System.ComponentModel.DataAnnotations;

namespace PassengerService.Model
{
    public class Passenger
    {
        [Key]
        public int PassengerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(1,120)]
        public int Age { get; set; }
    }
}
