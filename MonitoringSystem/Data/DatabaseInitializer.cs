using Npgsql;

namespace MonitoringSystem.Data
{
    public class DatabaseInitializer
    {
        private readonly string _connectionString;
        private readonly ILogger<DatabaseInitializer> _logger;

        public DatabaseInitializer(IConfiguration configuration, ILogger<DatabaseInitializer> logger)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Connection string is not found");
            _logger = logger;
        }

        public async Task InitializeAsync()
        {
            try
            {
                _logger.LogInformation("Attempting to connect to the database...");

                await using var connection = new NpgsqlConnection(_connectionString);
                await connection.OpenAsync();

                _logger.LogInformation("Database connection successful!");

                string sql = @"
                CREATE TABLE IF NOT EXISTS roles (
                RoleId SERIAL PRIMARY KEY,
                RoleName VARCHAR(100) NOT NULL UNIQUE
                );

                CREATE TABLE IF NOT EXISTS users (
                UserId SERIAL PRIMARY KEY,
                Username VARCHAR(100) NOT NULL,
                Password VARCHAR(150) NOT NULL,
                SerialNo VARCHAR(100) NOT NULL,
                LoginTime TIMESTAMP NOT NULL,
                RoleId INT NOT NULL,
                CONSTRAINT fk_users_roles FOREIGN KEY (RoleId) REFERENCES roles(RoleId) ON DELETE CASCADE
                );";

                await using var command = new NpgsqlCommand(sql, connection);
                await command.ExecuteNonQueryAsync();

                _logger.LogInformation("Database tables verified/created successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to connect to the database or create tables.");
                throw; // Rethrow to prevent the app from starting if the DB is broken
            }
        }
    }
}