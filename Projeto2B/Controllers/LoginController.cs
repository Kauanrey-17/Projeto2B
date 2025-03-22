using Microsoft.AspNetCore.Mvc;
using Projeto2B.Repositorio;

namespace Projeto2B.Controllers
{
    public class LoginController : Controller
    {
        // declara uma variavel privada somente leitura
        private readonly UsuarioRepositorio _usuarioRepositorio;

        //construtor 

        public LoginController(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
