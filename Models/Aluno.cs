namespace ProjectShcool_Api.Models
{
    public class Aluno
    {
        public int id {get; set;}
        public string nome {get; set;}
        public string sobrenome {get; set;}
        public string dataNasc {get; set;}
        public int professorId {get;set;}
    }
}