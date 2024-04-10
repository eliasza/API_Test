using System.Data.SqlClient;

namespace ThomasGregTest.Infra.CrossCutting.Ioc
{
    public class ApplicationDbContext
    {
        private readonly IConfiguration _configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection CreateConnection(string connectionString = "DefaultConnection")
        {
            string? connection = _configuration.GetConnectionString(connectionString);
            return new SqlConnection(connection);

        }
    }
}
