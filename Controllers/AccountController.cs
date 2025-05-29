using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Inventory_Management_System.Models;
using System.Linq;

namespace Inventory_Management_System.Controllers
{
    public class AccountController : Controller
    {
        private readonly InventoryDbContext _context;

        public AccountController(InventoryDbContext context)
        {
            _context = context;
        }

        // GET: /Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                ViewBag.Error = "Username and password are required.";
                return View();
            }

            var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            // TIP: For security, use hashed passwords in real applications.

            if (user != null)
            {
                HttpContext.Session.SetString("Username", user.Username);
                HttpContext.Session.SetString("Role", user.Role);

                return user.Role switch
                {
                    "Manager" => RedirectToAction("ManagerDashboard", "Home"),
                    "WarehouseStaff" => RedirectToAction("WarehouseDashboard", "Home"),
                    "Supplier" => RedirectToAction("SupplierDashboard", "Home"),
                    "User" => RedirectToAction("UserDashboard", "Home"),
                    _ => RedirectToAction("Login")
                };
            }

            ViewBag.Error = "Invalid username or password.";
            return View();
        }

        // GET: /Account/Logout
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
