using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory_Management_System.Models
{
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ItemId { get; set; }

        [Required(ErrorMessage = "Item name is required.")]
        public string ? Name { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be a non-negative integer.")]
        public int Quantity { get; set; }
        
        public DateTime LastUpdated { get; set; }
        public string? SupplierId { get; internal set; }
    }
}
