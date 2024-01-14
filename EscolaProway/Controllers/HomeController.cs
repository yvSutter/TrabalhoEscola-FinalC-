using EscolaProway.Models;
using EscolaProway.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EscolaProway.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAluno _Aluno;
        private readonly IProfessor _Professor;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IAluno alunoRepository, IProfessor professorRepository)
        {
            _logger = logger;
            _Aluno = alunoRepository;
            _Professor = professorRepository;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListAluno()
        {
            var aluno = _Aluno.Alunos;
            return View(aluno);
        }
        public IActionResult ListProfessor()
        {
            var professor = _Professor.Professores;
            return View(professor);
        }

        public IActionResult CadastroProfessor()
        {
            var professor = new Professor();
            List<Professor> listaProfessores = new List<Professor> { professor };

            // Passe apenas o primeiro professor da lista para a view
            return View(listaProfessores.FirstOrDefault());
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}