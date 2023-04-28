namespace data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationDbContext _DbContext;

        public UsuarioRepository(ApplicationDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public async Task Cadastrar(Usuario usuario)
        {
            await _DbContext.Usuarios.AddAsync(usuario);
            await _DbContext.SaveChangesAsync();
        }

        public async Task Atualizar(Usuario usuario)
        {
            _DbContext.Usuarios.Update(usuario);
            await _DbContext.SaveChangesAsync();
        }

        public async Task Excluir(Usuario usuario)
        {
            _DbContext.Usuarios.Remove(usuario);
            await _DbContext.SaveChangesAsync();
        }

        
    }
}