using Inventory_Management_System.Models;
using Microsoft.AspNetCore.Mvc; 

public class ManagerController : Controller
{
    private readonly InventoryDbContext _context;

    public ManagerController(InventoryDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var totalProducts = _context.Items.Count();
        var totalReports = _context.Orders.Count(); // or Reports.Count() if you have Reports
        var lowStockItems = _context.Items.Count(i => i.Quantity <= 10); // adjust threshold as needed

        ViewBag.TotalProducts = totalProducts;
        ViewBag.TotalReports = totalReports;
        ViewBag.LowStockItems = lowStockItems;

        return View();
    }
}
