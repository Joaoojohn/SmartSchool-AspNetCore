using System.Runtime.Intrinsics.Arm.Arm64;
using System.Net.Sockets;
using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.CompilerServices;
using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Data
{
    public SmartContext(DbContextOptions<SmartContext> options) : base(options)
    {
    }
    public class SmartContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }        
        
        public DbSet<Professor> Professores { get; set; }        
        
        public DbSet<Disciplina> Disciplinas { get; set; }        
        
        public DbSet<AlunoDisciplinas> AlunoDisciplinas { get; set; }       

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AlunoDisciplinas>()
            .HasKey(AD => new{AD.AlunoId, AD.DisciplinaId});
        }
    }
}