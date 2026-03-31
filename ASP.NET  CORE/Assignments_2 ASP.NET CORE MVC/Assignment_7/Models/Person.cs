using System.ComponentModel.DataAnnotations;

namespace Assignment_7.Models
{
    public class Person
    {

        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1,100)]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set;
        }
    }
}
