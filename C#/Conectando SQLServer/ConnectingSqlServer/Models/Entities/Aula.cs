using System.ComponentModel.DataAnnotations;


namespace ConnectingSqlServer.Models.Entities
{
    public class Aula
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Professor { get; set; }
        //confirmando realação n para n 
        public List<Aluno> Alunos { get; set; }


    }
}
