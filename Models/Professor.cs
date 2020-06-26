using System.Collections.Generic;

namespace ProjectShcool_Api.Models
{
    public class Professor
    {
        public int id {get; set;}
        public string nome {get; set;}
        public string sobrenome {get; set;}
        public string dataNasc {get; set;}
        public List<Aluno> alunos {get; set;}
    }
}