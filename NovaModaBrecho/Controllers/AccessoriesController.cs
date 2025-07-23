using Microsoft.AspNetCore.Mvc;
using NovaModaBrecho.Models;

namespace NovaModaBrecho.Controllers;

public class AccessoriesController : Controller
{

    // GET: /Accessories
    // lista todos os acessorios
    public IActionResult Index()
    {
        return View();
    }
    
    // GET: /Accessories/Details/{id}
    // mostra detalhes de um acessorio
    public IActionResult Details(int id)
    {
        return View();
    }
    
    // GET: /Accessories/Create
    // mostra forms para adicionar acessorio
    public IActionResult Create()
    {
        return View();
    }
    
    // POST: /Accessories/Create
    // posta forms com dados do novo acessorio
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Acessory acessorio)
    {
        return View();
    }
    
    // GET: /Accessories/Edit/{id}
    // mostra forms para editar dados de acessorio
    public IActionResult Edit(int id)
    {
        return View();
    }
    
    
    // POST: /Accessories/Edit/5
    // posta forms com edicoes
    [HttpPost]  
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Acessory acessorio)
    {
        return View(acessorio);
    }
    
    // GET: /Accessories/Delete/{id}
    // mostra forms para deletar
    public IActionResult Delete(int id)
    {
        return View();
    }

    // POST: /Accessories/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        return View();
    }
    
}