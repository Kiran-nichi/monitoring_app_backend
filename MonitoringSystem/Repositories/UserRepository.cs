using MonitoringSystem.DTO;
using Npgsql;
using System.Windows.Input;

namespace MonitoringSystem.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string connectionString;
        public UserRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection") ??
                throw new InvalidOperationException("Connection string is not found");
        }

        public Task<UserResponse> CreateUserAsync(UserRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<UserResponse> GetUserAsync(string username)
        {
            string query = @" SELECT * FROM USERS WHERE username=@username";
             var connection = new NpgsqlConnection(connectionString);
        }
    }
}
