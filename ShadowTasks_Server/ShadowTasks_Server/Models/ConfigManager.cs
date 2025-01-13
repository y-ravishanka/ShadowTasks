using Microsoft.Data.SqlClient;

namespace ShadowTasks_Server.Models
{
    public class ConfigManager
    {
        public static string Environment { get; set; }
        public static DBConnectionDetails DBConnectionDetails { get; set; }

        public static string ConnectionString => SetConnectionString(DBConnectionDetails);

        private static string SetConnectionString(DBConnectionDetails _model)
        {
            SqlConnectionStringBuilder builder = new()
            {
                DataSource = _model.DataSource,
                UserID = _model.UserId,
                Password = _model.Password,
                InitialCatalog = _model.InitialCatalog
            };

            return builder.ConnectionString;
        }
    }

    public class DBConnectionDetails
    {
        public string DataSource { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string InitialCatalog { get; set; }
    }
}
