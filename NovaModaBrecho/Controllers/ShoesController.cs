using Microsoft.AspNetCore.Mvc;
using NovaModaBrecho.Data;
using NovaModaBrecho.Models;
using NovaModaBrecho.Services.Interfaces; // Add this using directive

namespace NovaModaBrecho.Controllers;

public class ShoesController : Controller
{
    // Change the type to the interface
    private readonly IBaseItemService<Shoe> _shoesService;

    // Change the constructor parameter type to the interface
    public ShoesController(IBaseItemService<Shoe> shoesService)
    {
        _shoesService = shoesService;
    }

    // GET: /Shoes
    public IActionResult Index()
    {
        var shoes = SeedData.Items.OfType<Shoe>().ToList();
        return View(shoes);
    }

    // GET: /Shoes/Details/{id}
    public IActionResult Details(int id)
    {
        var shoe = _shoesService.GetById(id);
        if (shoe == null) return NotFound();
        return View(shoe);
    }

    // GET: /Shoes/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: /Shoes/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Shoe sapato)
    {
        if (ModelState.IsValid)
        {
            _shoesService.Add(sapato);
            return RedirectToAction(nameof(Index));
        }
        return View(sapato);
    }

    // GET: /Shoes/Edit/{id}
    public IActionResult Edit(int id)
    {
        var shoe = _shoesService.GetById(id);
        if (shoe == null) return NotFound();
        return View(shoe);
    }

    // POST: /Shoes/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Shoe sapato)
    {
        if (id != sapato.Id) return NotFound();
        if (ModelState.IsValid)
        {
            try
            {
                _shoesService.Update(sapato);
            }
            catch (Exception)
            {
                if (_shoesService.GetById(id) == null) return NotFound();
                throw;
            }
            return RedirectToAction(nameof(Index));
        }
        return View(sapato);
    }

    // GET: /Shoes/Delete/{id}
    public IActionResult Delete(int id)
    {
        var shoe = _shoesService.GetById(id);
        if (shoe == null) return NotFound();
        return View(shoe);
    }

    // POST: /Shoes/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        _shoesService.Delete(id);
        return RedirectToAction(nameof(Index));
    }
}