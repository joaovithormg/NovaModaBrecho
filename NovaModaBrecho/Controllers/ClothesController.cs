using Microsoft.AspNetCore.Mvc;
using NovaModaBrecho.Models;
using NovaModaBrecho.Services.Interfaces;
using NovaModaBrecho.Data;
using NovaModaBrecho.DTOs; // ADICIONAR ESTA LINHA

namespace NovaModaBrecho.Controllers;

public class ClothesController : Controller
{
    private readonly IBaseItemService<Cloth> _clothesService;

    public ClothesController(IBaseItemService<Cloth> clothesService)
    {
        _clothesService = clothesService;
    }
    
    public IActionResult Index()
    {
        var clothes = SeedData.Items.OfType<Cloth>().ToList();
        return View(clothes);
    }
    
    public IActionResult Details(int id)
    {
        var cloth = _clothesService.GetById(id);
        if (cloth == null) return NotFound();
        
        return View(cloth);
    }
    
    public IActionResult Create()
    {
        return View();
    }
    
    // SUBSTITUIR ESTE MÉTODO CREATE
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(ClothCreateDto dto)
    {
        if (ModelState.IsValid)
        {
            // Gerar novo ID (você pode ajustar esta lógica conforme sua necessidade)
            var newId = SeedData.Items.Any() ? SeedData.Items.Max(i => i.Id) + 1 : 1;
            
            var cloth = new Cloth(
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
                dto.ClothesSize,
                dto.ClothesCategory
            );
            
            _clothesService.Add(cloth);
            
            // Se foi chamado via AJAX (modal), retornar JSON
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest" || 
                Request.ContentType?.Contains("application/json") == true)
            {
                return Json(new { success = true, message = "Roupa criada com sucesso!" });
            }
            
            return RedirectToAction(nameof(Index));
        }
        
        // Se há erros de validação e foi AJAX, retornar os erros
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
        var cloth = _clothesService.GetById(id);
        if (cloth == null) return NotFound();
        return View(cloth);
    }
    
    [HttpPost]  
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Cloth roupa)
    {
        if (id != roupa.Id) return NotFound();
        if (ModelState.IsValid)
        {
            try
            {
                _clothesService.Update(roupa);
            }
            catch (Exception)
            {
                if(_clothesService.GetById(id) == null) return NotFound();
                throw;
            }
            return RedirectToAction(nameof(Index));
        }
        return View(roupa);
    }
    
    public IActionResult Delete(int id)
    {
        var cloth = _clothesService.GetById(id);
        if (cloth == null) return NotFound();
        return View(cloth); // CORRIGIDO: estava retornando View() sem parâmetro
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        _clothesService.Delete(id);
        return RedirectToAction(nameof(Index));
    }
}
