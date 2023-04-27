namespace web.Controllers
{
    [Route("sign")]
    public class SignController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public SignController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public IActionResult Index() => View();
        
        [HttpGet("sign-up")]
        public IActionResult SignUp() => View();

        [HttpPost("sign-up")]
        public async Task<IActionResult> EnviarCadastro(Usuario usuario)
        {
                await _usuarioRepository.Cadastrar(usuario);

                return RedirectToAction("Index", "sign");

        }
    }
}