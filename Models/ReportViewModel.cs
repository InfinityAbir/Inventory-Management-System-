namespace Inventory_Management_System.Models
{
    public class ReportViewModel
    {
        public int TotalProducts { get; set; }
        public int TotalOrders { get; set; }
        public List<Item> LowStockItems { get; set; }
    }
}
