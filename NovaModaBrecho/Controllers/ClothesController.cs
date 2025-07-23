using Microsoft.AspNetCore.Mvc;
using NovaModaBrecho.Models;

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
        return View();
    }
    
    // GET: /Clothes/Edit/{id}
    // mostra forms para editar dados de roupa
    public IActionResult Edit(int id)
    {
        return View();
    }
    
    
    // POST: /Clothes/Edit/5
    // posta forms com edicoes
    [HttpPost]  
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Cloth roupa)
    {
        return View(roupa);
    }
    
    // GET: /Clothes/Delete/{id}
    // mostra forms para deletar
    public IActionResult Delete(int id)
    {
        return View();
    }

    // POST: /Clothes/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        return View();
    }
    
}