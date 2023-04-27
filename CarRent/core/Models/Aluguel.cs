namespace core.Models
{
    public class Aluguel
    {
        public int Id { get; set; }
        public int IdCarro { get; set; }
        public int IdUsuario { get; set; }
        public DateTime InicioAluguel { get; set; }
        public DateTime FinalAluguel { get; set; }
        public decimal CustoTotal { get; set; }
        public bool Finalizado { get; set; }

        public Carro Carro { get; set; }

        public Usuario Usuario { get; set; }
    }
}