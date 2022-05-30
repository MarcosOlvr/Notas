using Microsoft.AspNetCore.Mvc;
using Notas.Data;
using Notas.Models;
using Notas.ViewModels;

namespace Notas.Controllers
{
    public class NotasController : Controller
    {
        private readonly ApplicationDbContext _db;

        public NotasController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult AddPrimeiroBi(int id)
        {
            var aluno = _db.Alunos.Find(id);

            if (aluno == null)
                return NotFound();

            var vm = new AddNotasVM();

            TempData["AlunoId"] = id;

            vm.Aluno = aluno;
            return View(vm);
        }
        
        [HttpPost]
        [Route("Notas/AddPrimeiroBi/{id}")]
        public IActionResult AddPrimeiroBiPost(AddNotasVM obj)
        {
            ModelState.Remove("Aluno");
            if (!ModelState.IsValid)
                return BadRequest(obj);

            if (TempData["AlunoId"] == null)
                return RedirectToAction("Index", "Home");

            int alunoId = int.Parse(TempData["AlunoId"].ToString());

            var aluno = _db.Alunos.Find(alunoId);

            if (aluno == null)
                return NotFound();

            var primeiroBi = new PrimeiroBi();
            primeiroBi.Portugues = obj.Portugues;
            primeiroBi.Matematica = obj.Matematica;
            primeiroBi.Historia = obj.Historia;
            primeiroBi.Geografia = obj.Geografia;
            primeiroBi.Ciencias = obj.Ciencias;
            primeiroBi.AlunoId = aluno.Id;

            _db.PrimeiroBi.Add(primeiroBi);
            _db.SaveChanges();

            return RedirectToRoute(new { controller = "Home", action = "AddNotas", id = aluno.Id });
        }
    }
}
