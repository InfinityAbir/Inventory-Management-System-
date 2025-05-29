using System.Diagnostics;
using Inventory_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Inventory_Management_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly InventoryDbContext _context;
        public HomeController(ILogger<HomeController> logger, InventoryDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ManagerDashboard()
        {
            if (HttpContext.Session.GetString("Role") != "Manager")
                return RedirectToAction("Login", "Account");

            ViewBag.TotalProducts = _context.Items.Count();
            ViewBag.TotalReports = _context.Orders.Count();
            ViewBag.LowStockItems = _context.Items.Count(i => i.Quantity <= 5);

            return View();
        }
        public IActionResult WarehouseDashboard()
        {
            if (HttpContext.Session.GetString("Role") != "WarehouseStaff")
                return RedirectToAction("Login", "Account");
            return View();
        }
        public IActionResult SupplierDashboard()
        {
            if (HttpContext.Session.GetString("Role") != "Supplier")
                return RedirectToAction("Login", "Account");
            return View();
        }
        public IActionResult UserDashboard()
        {
            if (HttpContext.Session.GetString("Role") != "User")
                return RedirectToAction("Login", "Account");
            return View();
        }
    }
}
