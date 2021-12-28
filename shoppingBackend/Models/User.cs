using System.ComponentModel.DataAnnotations;

namespace shoppingBackend.Models
{
    public class User
    {
       public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "defaultName";
        [Required]
        public string Surname { get; set; } = "defaultSurname";
        [Required]
        public string Email { get; set; } = "defaultEmail";
        [Required]
        public string Password { get; set; } = "defaultMessage";
        public string Address { get; set; } = "defaultAddress";



    }
}
