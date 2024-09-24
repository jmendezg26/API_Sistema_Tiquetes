using API_Sistema_Tiquetes.Entidades;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace API_Sistema_Tiquetes.AccesoDatos
{
    public class TiqueteAD
    {
        private readonly BDConnection _BDConnection = new BDConnection();

        #region Metodos Obtener

        public List<Tiquete> ObtenerTodosLosTiquetes()
        {
            List<Tiquete> ListaTiquetes = new List<Tiquete>();

            try
            {

                using SqlConnection conexion = new SqlConnection(_BDConnection.BD_CONEXION);

                conexion.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PA_ObtenerTiquetes";


                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Tiquete tiquete = new Tiquete
                    {
                        IdTiquete = int.Parse(reader[0].ToString()),
                        IdCliente = int.Parse(reader[0].ToString()),
                        IdSucursal = int.Parse(reader[0].ToString()),
                        IdContrato = int.Parse(reader[0].ToString()),
                        NumeroCaso = reader[4].ToString(),
                        NombreContacto = reader[5].ToString(),
                        CorreoContacto = reader[6].ToString(),
                        TelefonoContacto = reader[6].ToString(),
                        Titulo = reader[8].ToString(),
                        Detalle = reader[8].ToString(),
                        IdTipoPeticion = int.Parse(reader[9].ToString()),
                        IdTipoServicio = int.Parse(reader[9].ToString()),
                        Estado = int.Parse(reader[9].ToString()),
                        DetalleCierre = reader[8].ToString(),
                        FechaRegistro = DateTime.Parse(reader[11].ToString()),
                        FechaCierre = DateTime.Parse(reader[11].ToString()),
                        IdPrioridad = int.Parse(reader[9].ToString()),
                        EquipoSerie = reader[17].ToString(),
                        EquipoActivo = reader[18].ToString(),
                    };

                    ListaTiquetes.Add(tiquete);
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error al obtener los tiquetes", ex);
            }

            return ListaTiquetes;
        }
        #endregion

        #region Metodos Insertar
        #endregion

        #region Metodos Editar
        #endregion

        #region Metodos Eliminar
        #endregion


    }
}
