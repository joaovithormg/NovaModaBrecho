using Microsoft.AspNetCore.Mvc;
using NovaModaBrecho.Models;
using NovaModaBrecho.Services;

namespace NovaModaBrecho.Controllers;

public class AccessoriesController : Controller
{
    private readonly ItemService<Acessory> _accessoryService;

    public AccessoriesController(ItemService<Acessory> accessoryService)
    {
        _accessoryService = accessoryService;
    }

    // GET: /Accessories
    public IActionResult Index()
    {
        var accessories = _accessoryService.GetAll();
        return View(accessories);
    }

    // GET: /Accessories/Details/{id}
    public IActionResult Details(int id)
    {
        var accessory = _accessoryService.GetById(id);
        if (accessory == null) return NotFound();
        return View(accessory);
    }

    // GET: /Accessories/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: /Accessories/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Acessory acessorio)
    {
        if (ModelState.IsValid)
        {
            _accessoryService.Add(acessorio);
            return RedirectToAction(nameof(Index));
        }
        return View(acessorio);
    }

    // GET: /Accessories/Edit/{id}
    public IActionResult Edit(int id)
    {
        var accessory = _accessoryService.GetById(id);
        if (accessory == null) return NotFound();
        return View(accessory);
    }

    // POST: /Accessories/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Acessory acessorio)
    {
        if (id != acessorio.Id) return NotFound();
        if (ModelState.IsValid)
        {
            try
            {
                _accessoryService.Update(acessorio);
            }
            catch (Exception)
            {
                if (_accessoryService.GetById(id) == null) return NotFound();
                throw;
            }
            return RedirectToAction(nameof(Index));
        }
        return View(acessorio);
    }

    // GET: /Accessories/Delete/{id}
    public IActionResult Delete(int id)
    {
        var accessory = _accessoryService.GetById(id);
        if (accessory == null) return NotFound();
        return View(accessory);
    }

    // POST: /Accessories/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        _accessoryService.Delete(id);
        return RedirectToAction(nameof(Index));
    }
}
