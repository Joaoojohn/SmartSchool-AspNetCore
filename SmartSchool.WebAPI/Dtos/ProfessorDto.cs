using System;
namespace SmartSchool.WebAPI.Dtos
{
    public class ProfessorDto
    {
        public int Id { get; set; }
        public int Registro { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public DateTime  DataNasc{ get; set; }
        public DateTime  DataIni {get; set; }
        public DateTime?  Datafim {get; set; }
        public bool Ativo { get; set; }
    }
}