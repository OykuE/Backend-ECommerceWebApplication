using System.ComponentModel.DataAnnotations;

namespace shoppingBackend.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "defaultName";
        public int CategoryId { get; set; }
        public int Price { get; set; }
        public byte[] Image { get; set; }  

    }
}
