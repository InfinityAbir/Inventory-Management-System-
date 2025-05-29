using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory_Management_System.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        [ForeignKey("Item")]
        public int ? ItemId { get; set; }
        public Item ? Item { get; set; } = null!;  // Foreign key
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be a positive integer.")]
        public int Quantity { get; set; }

        public string OrderedBy { get; set; } = string.Empty; // Username or Role

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public string Status { get; set; } = "Pending"; // Pending, Approved, Received
        public string? SupplierId { get; internal set; }
    }
}
