using API_Sistema_Tiquetes.AccesoDatos;
using API_Sistema_Tiquetes.Entidades;

namespace API_Sistema_Tiquetes.LogicaNegocio
{
    public class UsuarioLN
    {
        private readonly UsuarioAD _UsuarioAD = new UsuarioAD();

        #region Metodos Obtener
        public UsuarioTecnico IniciarSesion(string Correo, string Clave)
        {
            UsuarioTecnico ElUsuario = new UsuarioTecnico();

            try
            {
                ElUsuario = _UsuarioAD.IniciarSesion(Correo, Clave);

                return ElUsuario;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error al obtener el usuario", ex);
            }
        }


        #endregion Metodos Obtener
    }
}
