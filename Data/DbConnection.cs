using Microsoft.Data.SqlClient;
namespace Practical9_PlacementDashboard.Data;
public class DbConnection
{
    private readonly string _connectionString;
    public DbConnection(IConfiguration configuration) =>
        _connectionString = configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException("Missing DefaultConnection.");
    public SqlConnection CreateConnection() => new SqlConnection(_connectionString);
}
