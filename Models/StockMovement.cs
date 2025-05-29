using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory_Management_System.Models
{
    public class StockMovement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StockMovementId { get; set; }
        [ForeignKey(nameof(Item))]
        public int ItemId { get; set; }
        public Item Item { get; set; } = null!; // Navigation property to Item
        public string Action { get; set; } = string.Empty;// Added, Removed, Updated
        public int QuantityChanged { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.UtcNow;
    }
}
