namespace core.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public DateTime Ano { get; set; }
        public decimal PrecoDia { get; set; }
    }
}