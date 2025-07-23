using Microsoft.AspNetCore.Mvc;
using NovaModaBrecho.Models;

namespace NovaModaBrecho.Controllers;

public class ShoesController : Controller
{

    // GET: /Shoes
    // lista todos os sapatos
    public IActionResult Index()
    {
        return View();
    }
    
    // GET: /Shoes/Details/{id}
    // mostra detalhes de um sapato
    public IActionResult Details(int id)
    {
        return View();
    }
    
    // GET: /Shoes/Create
    // mostra forms para adicionar sapato
    public IActionResult Create()
    {
        return View();
    }
    
    // POST: /Shoes/Create
    // posta forms com dados do novo sapato
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Shoe sapato)
    {
        return View();
    }
    
    // GET: /Shoes/Edit/{id}
    // mostra forms para editar dados de sapato
    public IActionResult Edit(int id)
    {
        return View();
    }
    
    
    // POST: /Shoes/Edit/5
    // posta forms com edicoes
    [HttpPost]  
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Shoe sapato)
    {
        return View(sapato);
    }
    
    // GET: /Shoes/Delete/{id}
    // mostra forms para deletar
    public IActionResult Delete(int id)
    {
        return View();
    }

    // POST: /Shoes/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        return View();
    }
    
}