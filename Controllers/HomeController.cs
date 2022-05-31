using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Notas.Data;
using Notas.Models;
using System.Diagnostics;

namespace Notas.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var alunos = _db.Alunos.ToList();

            return View(alunos);
        }

        public IActionResult AddNotas(int id)
        {
            var aluno = _db.Alunos.Find(id);

            if (aluno == null)
                return NotFound();

            return View(aluno);
        }
    }
}