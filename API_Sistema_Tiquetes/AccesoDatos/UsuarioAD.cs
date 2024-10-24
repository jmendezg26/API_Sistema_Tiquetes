using API_Sistema_Tiquetes.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace API_Sistema_Tiquetes.AccesoDatos
{
    public class UsuarioAD
    {
        private readonly BDConnection _BDConnection = new BDConnection();

        #region Metodos Obtener
        public UsuarioTecnico IniciarSesion(string Correo, string Clave)
        {
            UsuarioTecnico ElUsuario = new UsuarioTecnico();

            try
            {
                using SqlConnection conexion = new SqlConnection(_BDConnection.BD_CONEXION);

                conexion.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PA_IniciarSesion";
                cmd.Parameters.AddWithValue("@Correo", Correo);
                cmd.Parameters.AddWithValue("@Clave", Clave);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ElUsuario.Id = int.Parse(reader[0].ToString());
                    ElUsuario.IdRol = int.Parse(reader[1].ToString());
                    ElUsuario.Nombre = reader[2].ToString();
                    ElUsuario.Correo = reader[3].ToString();
                    ElUsuario.Telefono = reader[4].ToString();
                    ElUsuario.Cedula = reader[5].ToString();
                    ElUsuario.Puesto = reader[6].ToString();
                    ElUsuario.Departamento = reader[7].ToString();
                    ElUsuario.Estado = int.Parse(reader[8].ToString());

                }

                return ElUsuario;

            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error al obtener el usuario", ex);
            }
        }
        #endregion
    }
}
