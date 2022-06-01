using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Notas.Data;
using Notas.Models;
using Notas.ViewModels;
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
        
        public IActionResult VerNotas(int id)
        {
            var vm = new VerNotasVM();
            var aluno = _db.Alunos.Find(id);

            if (aluno == null)
                return NotFound();

            vm.Aluno = aluno;
            vm.PrimeiroBi = _db.PrimeiroBi.FirstOrDefault(x => x.AlunoId == aluno.Id);
            vm.SegundoBi = _db.SegundoBi.FirstOrDefault(x => x.AlunoId == aluno.Id);
            vm.TerceiroBi = _db.TerceiroBi.FirstOrDefault(x => x.AlunoId == aluno.Id);
            vm.QuartoBi = _db.QuartoBi.FirstOrDefault(x => x.AlunoId == aluno.Id);

            return View(vm);
        }
    }
}