using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NovaModaBrecho.Data;
using NovaModaBrecho.Models;

namespace NovaModaBrecho.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // GET: /Home
    // lista tudo
    public IActionResult Index()
    {
        var allItems = SeedData.Items.OrderByDescending(i => i.ReceiveDate).ToList();
        return View(allItems);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    
    public IActionResult Details(int id)
    {
        var item = SeedData.Items.FirstOrDefault(i => i.Id == id);
        if (item == null) return NotFound();

        if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
        {
            switch (item)
            {
                case Shoe shoe:
                    return PartialView("~/Views/Shoes/_DetailsPartial.cshtml", shoe);
                case Cloth cloth:
                    return PartialView("~/Views/Clothes/_DetailsPartial.cshtml", cloth);
                case Accessory accessory:
                    return PartialView("~/Views/Accessories/_DetailsPartial.cshtml", accessory);
                default:
                    return BadRequest();
            }
        }

        return View(item); 
    }

}