using Microsoft.AspNetCore.Mvc;
using NovaModaBrecho.Data;
using NovaModaBrecho.Models;
using NovaModaBrecho.Services.Interfaces;
using NovaModaBrecho.DTOs; // ADICIONAR ESTA LINHA

namespace NovaModaBrecho.Controllers;

public class ShoesController : Controller
{
    private readonly IBaseItemService<Shoe> _shoesService;

    public ShoesController(IBaseItemService<Shoe> shoesService)
    {
        _shoesService = shoesService;
    }

    public IActionResult Index()
    {
        var shoes = SeedData.Items.OfType<Shoe>().ToList();
        return View(shoes);
    }

    public IActionResult Details(int id)
    {
        var shoe = _shoesService.GetById(id);
        if (shoe == null) return NotFound();
        return View(shoe);
    }

    public IActionResult Create()
    {
        return View();
    }

    // SUBSTITUIR ESTE MÉTODO CREATE
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(ShoeCreateDto dto)
    {
        if (ModelState.IsValid)
        {
            var newId = SeedData.Items.Any() ? SeedData.Items.Max(i => i.Id) + 1 : 1;
            
            var shoe = new Shoe(
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
                dto.ShoeSize,
                dto.ShoesCategory
            );
            
            _shoesService.Add(shoe);
            
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest" || 
                Request.ContentType?.Contains("application/json") == true)
            {
                return Json(new { success = true, message = "Calçado criado com sucesso!" });
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

    // MANTER OS OUTROS MÉTODOS COMO ESTÃO
    public IActionResult Edit(int id)
    {
        var shoe = _shoesService.GetById(id);
        if (shoe == null) return NotFound();
        return View(shoe);
    }

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

    public IActionResult Delete(int id)
    {
        var shoe = _shoesService.GetById(id);
        if (shoe == null) return NotFound();
        return View(shoe);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        _shoesService.Delete(id);
        return RedirectToAction(nameof(Index));
    }
}
