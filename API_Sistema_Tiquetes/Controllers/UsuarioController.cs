using API_Sistema_Tiquetes.Entidades;
using API_Sistema_Tiquetes.LogicaNegocio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API_Sistema_Tiquetes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        private readonly UsuarioLN _UsuarioLN = new UsuarioLN();

        #region Metodos Obtener

        [HttpPost("IniciarSesion")]
        [AllowAnonymous]
        public async Task<IActionResult> IniciarSesion([FromBody] InicioSesion Login) 
        {
            UsuarioTecnico ElUsuario = new UsuarioTecnico();

            try
            {
                ElUsuario = _UsuarioLN.IniciarSesion(Login.Correo, Login.Clave);

                if (ElUsuario.Id != 0)
                {
                    return StatusCode(StatusCodes.Status200OK, JsonConvert.SerializeObject(new { msg = ElUsuario, success = true }));
                }
                else
                {
                    return StatusCode(StatusCodes.Status200OK, JsonConvert.SerializeObject(new { msg = "Credenciales Incorrectas", success = false }));
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { msg = "Imposible ejecutar su transación", success = false });
            }
        }

        #endregion Metodos Obtener
    }
}
