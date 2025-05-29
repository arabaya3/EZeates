using System.ComponentModel.DataAnnotations;

namespace EZeates.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public bool StockAvailability { get; set; }

        
    



    }
}
