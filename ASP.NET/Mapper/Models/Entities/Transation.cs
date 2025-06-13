namespace Mapper.Models.Entities
{
    public class Transation
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public float Value { get; set; }
        public User User { get; set; }
    }
}