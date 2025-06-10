
using System.ComponentModel.DataAnnotations;


namespace ConnectingSqlServer.Models.Entities
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        //definindo relaçao N para N
        public List<Aula> Aulas { get; set; }


    }
}
