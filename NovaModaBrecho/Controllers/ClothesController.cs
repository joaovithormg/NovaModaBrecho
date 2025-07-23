using Microsoft.AspNetCore.Mvc;
using NovaModaBrecho.Models;
using NovaModaBrecho.Services;

namespace NovaModaBrecho.Controllers;

public class ClothesController : Controller
{

    private readonly ItemService<Cloth> _clothesService;

    public ClothesController(ItemService<Cloth> clothesService)
    {
        _clothesService = clothesService;
    }
    
    // GET: /Clothes
    // lista todas as roupas
    public IActionResult Index()
    {
        var clothes = _clothesService.GetAll();
        return View(clothes);
    }
    
    // GET: /Clothes/Details/{id}
    // mostra detalhes de uma roupa
    public IActionResult Details(int id)
    {
        var cloth = _clothesService.GetById(id);
        if (cloth == null) return NotFound();
        
        return View(cloth);
    }
    
    // GET: /Clothes/Create
    // mostra forms para adicionar roupa
    public IActionResult Create()
    {
        return View();
    }
    
    // POST: /Clothes/Create
    // posta forms com dados da nova roupa
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Cloth roupa)
    {
        if (ModelState.IsValid)
        {
            _clothesService.Add(roupa);
            return RedirectToAction(nameof(Index));
        }
        return View(roupa);
    }
    
    // GET: /Clothes/Edit/{id}
    // mostra forms para editar dados de roupa
    public IActionResult Edit(int id)
    {
        var cloth = _clothesService.GetById(id);
        if (cloth == null) return NotFound();
        return View(cloth);
    }
    
    
    // POST: /Clothes/Edit/5
    // posta forms com edicoes
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
    
    // GET: /Clothes/Delete/{id}
    // mostra forms para deletar
    public IActionResult Delete(int id)
    {
        var cloth = _clothesService.GetById(id);
        if (cloth == null) return NotFound();
        return View();
    }

    // POST: /Clothes/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        _clothesService.Delete(id);
        return RedirectToAction(nameof(Index));
    }
}