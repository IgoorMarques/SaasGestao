using Entities.Entidades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;
        public UsuarioController(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        [Produces("application/json")]
        [HttpPost("/api/usuario")]
        public async Task<IActionResult> AddUsuario([FromBody] Usuario novoUsuario)
        {
            if (string.IsNullOrWhiteSpace(novoUsuario.Email) || string.IsNullOrWhiteSpace(novoUsuario.Email)
                || string.IsNullOrWhiteSpace(novoUsuario.PasswordHash))
            {
                return Ok("Falta alguns dados");
            }

            var user = new Usuario
            {
                Email = novoUsuario.Email,
                UserName = novoUsuario.Email,
                Nome = novoUsuario.Nome,
            };

            var result = await _userManager.CreateAsync(user, novoUsuario.PasswordHash);

            if (result.Errors.Any())
            {
                return Ok(result.Errors);
            }

            //Geração de confirmação de email
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));

            var response_return = await _userManager.ConfirmEmailAsync(user, code);

            if (response_return.Succeeded)
            {
                return Ok("Usuário cadastrado");
            }
            else
            {
                return Ok("Erro ao confirmar cadastro");
            }

        }
    }
}
