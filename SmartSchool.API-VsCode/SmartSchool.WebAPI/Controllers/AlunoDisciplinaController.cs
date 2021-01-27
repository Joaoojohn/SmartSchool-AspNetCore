using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.WebAPI.Controllers
{
    public class AlunoDisciplinaController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAction()
        {
            return Ok("Alunos: Andreza, João, Gabriele");
        }
    }
}