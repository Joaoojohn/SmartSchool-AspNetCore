using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.WebAPI.Controllers
{
    public class DisciplinaController : ControllerBase
    {
        public DisciplinaController(){}
        
        [HttpGet]
        public IActionResult GetAction()
        {
            return Ok("Alunos: Andreza, João, Gabriele, Eduardo");
        }
    }
}