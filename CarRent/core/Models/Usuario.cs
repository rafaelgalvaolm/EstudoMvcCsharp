namespace core.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; } // TODO: Criar validação de email
        public string Senha { get; set; } 
        public bool IsAdmin { get; set; }
    }
}