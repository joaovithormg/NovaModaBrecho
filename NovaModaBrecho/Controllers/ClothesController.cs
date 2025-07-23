using Microsoft.AspNetCore.Mvc;

namespace NovaModaBrecho.Controllers;

public class ClothesController : Controller
{

    // GET: /Clothes
    // lista todas as roupas
    public IActionResult Index()
    {
        return View();
    }
    
    // GET: /Clothes/Details/{id}
    // mostra detalhes de uma roupa
    public IActionResult Details(int id)
    {
        return View();
    }
    
}