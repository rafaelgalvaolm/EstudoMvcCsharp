namespace core.Models
{
    public class Aluguel
    {
        public int Id { get; set; }
        public int IdCarro { get; set; }
        public int IdCliente { get; set; }
        public int IdFuncionario { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public decimal ValorTotal { get; set; }
        public bool Finalizado { get; set; }
    }
}