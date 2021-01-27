using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>()
        {
            new Aluno()
            {
                Id = 1,
                Nome= "João",
                Sobrenome= "Costa",
                Telefone = "45648794966"
            },
            new Aluno()
            {
                Id = 2,
                Nome= "Andreza",
                Sobrenome= "Leal Muller",
                Telefone = "45150594966"
            },
            new Aluno()
            {
                Id = 3,
                Nome= "Gabriele",
                Sobrenome= "Trevisan",
                Telefone = "45648721266"
            },
        };

        public AlunoController(){}
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        [HttpGet("byid/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            
            if(aluno==null)
            return BadRequest("Aluno não encontrado");

            return Ok(aluno);
        }
        

        [HttpGet("ByName")]
        public IActionResult GetByName(string nome, string sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(n => n.Nome.Contains(nome) && n.Sobrenome.Contains(sobrenome));
            
            if(aluno==null)
            return BadRequest("Aluno não encontrado");

            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPatch("{id}")]

        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}