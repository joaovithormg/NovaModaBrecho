using Microsoft.AspNetCore.Mvc;
using NovaModaBrecho.Data;
using NovaModaBrecho.Models;
using NovaModaBrecho.Services.Interfaces;
using NovaModaBrecho.DTOs; 

namespace NovaModaBrecho.Controllers;

public class AccessoriesController : Controller
{
    private readonly IBaseItemService<Accessory> _accessoryService;

    public AccessoriesController(IBaseItemService<Accessory> accessoryService)
    {
        _accessoryService = accessoryService;
    }

    public IActionResult Index()
    {
        var accessories = SeedData.Items.OfType<Accessory>().ToList();
        return View(accessories);
    }

    public IActionResult Details(int id)
    {
        var accessory = _accessoryService.GetById(id);
        if (accessory == null) return NotFound();
        return View(accessory);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(AccessoryCreateDto dto)
    {
        if (ModelState.IsValid)
        {
            var newId = SeedData.Items.Any() ? SeedData.Items.Max(i => i.Id) + 1 : 1;
            
            var accessory = new Accessory(
                newId,
                dto.Url ?? string.Empty,
                dto.Name,
                dto.Description ?? string.Empty,
                dto.Brand,
                dto.Origin,
                dto.Quantity,
                dto.Color,
                dto.OriginalPrice,
                dto.ReceiveDate,
                dto.Condition,
                dto.AccessoriesSize,
                dto.AccessoriesType
            );
            
            _accessoryService.Add(accessory);
            
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest" || 
                Request.ContentType?.Contains("application/json") == true)
            {
                return Json(new { success = true, message = "Acessório criado com sucesso!" });
            }
            
            return RedirectToAction(nameof(Index));
        }
        
        if (Request.Headers["X-Requested-With"] == "XMLHttpRequest" || 
            Request.ContentType?.Contains("application/json") == true)
        {
            return BadRequest(ModelState);
        }
        
        return View(dto);
    }

    public IActionResult Edit(int id)
    {
        var accessory = _accessoryService.GetById(id);
        if (accessory == null) return NotFound();
        return View(accessory);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Accessory acessorio)
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

    public IActionResult Delete(int id)
    {
        var accessory = _accessoryService.GetById(id);
        if (accessory == null) return NotFound();
        return View(accessory);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        _accessoryService.Delete(id);
        return RedirectToAction(nameof(Index));
    }
}