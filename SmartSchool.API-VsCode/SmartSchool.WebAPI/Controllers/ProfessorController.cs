using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.WebAPI.Controllers
{
    public class ProfessorController : ControllerBase
    {
        public ProfessorController(){}
        
        [HttpGet]
        public IActionResult GetAction()
        {
            return Ok("Alunos: Andreza, João, Gabriele, Eduardo");
        }
    }
}