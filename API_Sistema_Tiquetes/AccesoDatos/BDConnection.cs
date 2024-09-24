namespace API_Sistema_Tiquetes.AccesoDatos
{
    public class BDConnection
    {
        private static IConfiguration _configuration;

        public static void SetDBConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string BD_CONEXION
        {

            get { return _configuration.GetConnectionString("BDTiquetes"); }

        }

        public string DBConnectionApi()
        {
            string conexion = string.Empty;

            try
            {
                conexion = BD_CONEXION;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
            return conexion;
        }

        public string GetConnectionString(string connectionName)
        {
            throw new NotImplementedException();
        }

        public interface IDbConnection
        {
            string GetConnectionString(string connectionName);
        }
    }
}

