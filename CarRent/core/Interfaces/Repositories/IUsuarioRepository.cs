namespace core.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        Task Cadastrar(Usuario usuario);
    }
}