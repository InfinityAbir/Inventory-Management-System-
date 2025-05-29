using Microsoft.AspNetCore.Mvc;
using Inventory_Management_System.Models;
using System.Linq;

public class ReportsController : Controller
{
    private readonly InventoryDbContext _context;

    public ReportsController(InventoryDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var totalProducts = _context.Items.Count();
        var lowStockItems = _context.Items.Where(i => i.Quantity < 10).ToList();
        var totalOrders = _context.Orders.Count();

        var model = new ReportViewModel
        {
            TotalProducts = totalProducts,
            TotalOrders = totalOrders,
            LowStockItems = lowStockItems
        };

        return View(model);
    }
}
