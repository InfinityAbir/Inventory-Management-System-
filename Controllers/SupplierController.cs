using Inventory_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

[Authorize(Roles = "Supplier")] // Optional: restrict access to suppliers only
public class SupplierController : Controller
{
    private readonly InventoryDbContext _context;

    public SupplierController(InventoryDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        // Get logged-in supplier's user id or supplier id
        var supplierId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        // Or if you store supplier id as a claim, adjust accordingly.

        // Filter data by supplierId, replace 'SupplierId' with actual field name in your DB
        var pendingDeliveries = _context.Orders
            .Count(o => o.Status == "Pending" && o.SupplierId == supplierId);

        var totalProductsSupplied = _context.Items
            .Count(i => i.SupplierId == supplierId);

        var supplyReportCount = _context.Orders
            .Count(o => o.SupplierId == supplierId);

        ViewBag.PendingDeliveries = pendingDeliveries;
        ViewBag.TotalProductsSupplied = totalProductsSupplied;
        ViewBag.SupplyReportCount = supplyReportCount;

        return View();
    }
}
