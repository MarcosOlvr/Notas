using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Notas.Data;
using Notas.Models;
using Notas.ViewModels;

namespace Notas.Controllers
{
    [Authorize]
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

            if (VerificarPrimeiroBi(aluno.Id) == true)
                vm.TemNotaPrimeiroBi = true;

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

            if (VerificarPrimeiroBi(alunoId) == true)
                return BadRequest();

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
        
        [HttpGet]
        public IActionResult AddSegundoBi(int id)
        {
            var aluno = _db.Alunos.Find(id);

            if (aluno == null)
                return NotFound();

            var vm = new AddNotasVM();

            TempData["AlunoId"] = id;

            if (VerificarSegundoBi(aluno.Id) == true)
                vm.TemNotaSegundoBi = true;

            vm.Aluno = aluno;
            return View(vm);
        }
        
        [HttpPost]
        [Route("Notas/AddSegundoBi/{id}")]
        public IActionResult AddSegundoBiPost(AddNotasVM obj)
        {
            ModelState.Remove("Aluno");
            if (!ModelState.IsValid)
                return BadRequest(obj);

            if (TempData["AlunoId"] == null)
                return RedirectToAction("Index", "Home");

            int alunoId = int.Parse(TempData["AlunoId"].ToString());

            if (VerificarSegundoBi(alunoId) == true)
                return BadRequest();

            var aluno = _db.Alunos.Find(alunoId);

            if (aluno == null)
                return NotFound();

            var segundoBi = new SegundoBi();
            segundoBi.Portugues = obj.Portugues;
            segundoBi.Matematica = obj.Matematica;
            segundoBi.Historia = obj.Historia;
            segundoBi.Geografia = obj.Geografia;
            segundoBi.Ciencias = obj.Ciencias;
            segundoBi.AlunoId = aluno.Id;

            _db.SegundoBi.Add(segundoBi);
            _db.SaveChanges();

            return RedirectToRoute(new { controller = "Home", action = "AddNotas", id = aluno.Id });
        }
        
        [HttpGet]
        public IActionResult AddTerceiroBi(int id)
        {
            var aluno = _db.Alunos.Find(id);

            if (aluno == null)
                return NotFound();

            var vm = new AddNotasVM();

            TempData["AlunoId"] = id;

            if (VerificarTerceiroBi(aluno.Id) == true)
                vm.TemNotaTerceiroBi = true;

            vm.Aluno = aluno;
            return View(vm);
        }
        
        [HttpPost]
        [Route("Notas/AddTerceiroBi/{id}")]
        public IActionResult AddTerceiroBiPost(AddNotasVM obj)
        {
            ModelState.Remove("Aluno");
            if (!ModelState.IsValid)
                return BadRequest(obj);

            if (TempData["AlunoId"] == null)
                return RedirectToAction("Index", "Home");

            int alunoId = int.Parse(TempData["AlunoId"].ToString());

            if (VerificarTerceiroBi(alunoId) == true)
                return BadRequest();

            var aluno = _db.Alunos.Find(alunoId);

            if (aluno == null)
                return NotFound();

            var terceiroBi = new TerceiroBi();
            terceiroBi.Portugues = obj.Portugues;
            terceiroBi.Matematica = obj.Matematica;
            terceiroBi.Historia = obj.Historia;
            terceiroBi.Geografia = obj.Geografia;
            terceiroBi.Ciencias = obj.Ciencias;
            terceiroBi.AlunoId = aluno.Id;

            _db.TerceiroBi.Add(terceiroBi);
            _db.SaveChanges();

            return RedirectToRoute(new { controller = "Home", action = "AddNotas", id = aluno.Id });
        }

        [HttpGet]
        public IActionResult AddQuartoBi(int id)
        {
            var aluno = _db.Alunos.Find(id);

            if (aluno == null)
                return NotFound();

            var vm = new AddNotasVM();

            TempData["AlunoId"] = id;

            if (VerificarQuartoBi(aluno.Id) == true)
                vm.TemNotaQuartoBi = true;

            vm.Aluno = aluno;
            return View(vm);
        }
        
        [HttpPost]
        [Route("Notas/AddQuartoBi/{id}")]
        public IActionResult AddQuartoBiPost(AddNotasVM obj)
        {
            ModelState.Remove("Aluno");
            if (!ModelState.IsValid)
                return BadRequest(obj);

            if (TempData["AlunoId"] == null)
                return RedirectToAction("Index", "Home");

            int alunoId = int.Parse(TempData["AlunoId"].ToString());

            if (VerificarQuartoBi(alunoId) == true)
                return BadRequest();

            var aluno = _db.Alunos.Find(alunoId);

            if (aluno == null)
                return NotFound();

            var quartoBi = new QuartoBi();
            quartoBi.Portugues = obj.Portugues;
            quartoBi.Matematica = obj.Matematica;
            quartoBi.Historia = obj.Historia;
            quartoBi.Geografia = obj.Geografia;
            quartoBi.Ciencias = obj.Ciencias;
            quartoBi.AlunoId = aluno.Id;

            _db.QuartoBi.Add(quartoBi);
            _db.SaveChanges();

            return RedirectToRoute(new { controller = "Home", action = "AddNotas", id = aluno.Id });
        }

        public bool VerificarPrimeiroBi(int alunoId)
        {
            //Verificando se o aluno ja tem uma nota cadastrada no primeiro bimestre

            var primeiroBi = _db.PrimeiroBi.FirstOrDefault(x => x.AlunoId == alunoId);

            if (primeiroBi == null)
                return false;

            return true;
        }

        public bool VerificarSegundoBi(int alunoId)
        {
            //Verificando se o aluno ja tem uma nota cadastrada no segundo bimestre

            var segundoBi = _db.SegundoBi.FirstOrDefault(x => x.AlunoId == alunoId);

            if (segundoBi == null)
                return false;

            return true;
        }

        public bool VerificarTerceiroBi(int alunoId)
        {
            //Verificando se o aluno ja tem uma nota cadastrada no terceiro bimestre

            var terceiroBi = _db.TerceiroBi.FirstOrDefault(x => x.AlunoId == alunoId);

            if (terceiroBi == null)
                return false;

            return true;
        }

        public bool VerificarQuartoBi(int alunoId)
        {
            //Verificando se o aluno ja tem uma nota cadastrada no quarto bimestre

            var quartoBi = _db.QuartoBi.FirstOrDefault(x => x.AlunoId == alunoId);

            if (quartoBi == null)
                return false;

            return true;
        }
    }
}
