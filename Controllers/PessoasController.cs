using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using projetoProva.Models;

namespace projetoProva.Controllers;

public class PessoasController : Controller
{
    public IActionResult Index()
    {
        return View(RepositorioPessoas.Pessoas);
    }

    [HttpPost]
    public IActionResult Adicionar(Pessoa pessoa)
    {
        RepositorioPessoas.AdicionarPessoa(pessoa);
        return RedirectToAction("Index");
    }
    public IActionResult Remover(string Id)
    {
        int aux;
        
        if (int.TryParse(Id, out aux)) {
            RepositorioPessoas.RemoverPessoa(aux); 
        }
        return RedirectToAction("Index");
    }
}