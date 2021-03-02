using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;
using SmartSchool.WebAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        private readonly SmartContext _context;

        public ProfessorController(SmartContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult GetAction()
        {
            return Ok(_context.Professores);
        }
        
        [HttpGet("byid/{id}")]
        public IActionResult GetById(int id)
        {
            var prof = _context.Professores.FirstOrDefault(p => p.Id == id);
            
            if(prof==null)
            return BadRequest("Professor não encontrado");

            return Ok(prof);
        }

        [HttpGet("ByName")]
        public IActionResult GetByName(string Nome)
        {
            var prof = _context.Professores.FirstOrDefault(n => n.Nome.Contains(Nome));
            
            if(prof==null)
            return BadRequest("Professor não encontrado");

            return Ok(prof);
        }

        [HttpPost]
        public IActionResult Post(Professor professor)
        {
            _context.Add(professor);
            _context.SaveChanges(); 

            return Ok(professor);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Professor professor)
        {
            var prof = _context.Professores.AsNoTracking().FirstOrDefault(p => p.Id == id);
            
            if (prof==null) return BadRequest("Professor não encontrado");

            _context.Update(professor);
            _context.SaveChanges();

            return Ok(professor);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Professor professor)
        {
            var prof = _context.Professores.AsNoTracking().FirstOrDefault(p => p.Id == id);
            
            if (prof==null) return BadRequest("Professor não encontrado");

            _context.Update(professor);
            _context.SaveChanges();

             return Ok(professor);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var professor = _context.Professores.FirstOrDefault(p => p.Id == id);

            if (professor==null) return BadRequest("Professor não encontrado");

            _context.Remove(professor);
            _context.SaveChanges();
 
            return Ok(professor);
        } 
    } 
}