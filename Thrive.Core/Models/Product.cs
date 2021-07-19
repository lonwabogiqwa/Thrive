using System.ComponentModel.DataAnnotations;

namespace Thrive.Core.Models
{
   public class Product
    {
      
        public int ProductId { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        [Required]
        public byte[] Image { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
