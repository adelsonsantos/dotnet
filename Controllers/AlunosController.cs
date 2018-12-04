using Microsoft.AspNetCore.Mvc;
using PrimeiraAplicacao.Models;

namespace PrimeiraAplicacao.Controllers
{
    public class AlunosController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return Content("Teste com alunos");
        }
        
        
        public IActionResult Listar()
        {
            var alunos = AlunoRepository.Getall();
            return View(alunos);
        }

        public IActionResult Visualizar(int id)
        {
            string nome = Request.Query["nome"];
            ViewData["nome"] = nome;
            ViewData["id"] = id;
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cadastrar(Aluno aluno)
        {
            return Content($"Nome: {aluno.Nome}, Nota Final: {aluno.NotaFinal}");
        }
    }
}