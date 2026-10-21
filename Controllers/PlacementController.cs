using Microsoft.AspNetCore.Mvc;
using Practical9_PlacementDashboard.Data;
namespace Practical9_PlacementDashboard.Controllers;
public class PlacementController : Controller
{
    private readonly PlacementRepository _repository;
    public PlacementController(PlacementRepository repository) => _repository = repository;

    public async Task<IActionResult> Index(string status = "All")
    {
        string[] allowed = { "All", "Placed", "In Process", "Not Placed" };
        if (!allowed.Contains(status)) status = "All";
        return View(await _repository.GetDashboardAsync(status));
    }

    public async Task<IActionResult> Report(string status = "All")
    {
        string[] allowed = { "All", "Placed", "In Process", "Not Placed" };
        if (!allowed.Contains(status)) status = "All";
        return View(await _repository.GetDashboardAsync(status));
    }

    public IActionResult Error() => View("Error");
}
