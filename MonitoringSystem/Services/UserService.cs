using MonitoringSystem.Data;
using MonitoringSystem.DTO;
using MonitoringSystem.Repositories;

namespace MonitoringSystem.Services
{
    public class UserService : IUserRepository
    {
        private readonly AppDbContext _dbContext;
        public UserService(AppDbContext Dbcontext)
        {
            _dbContext = Dbcontext; 
        }
        public Task<UserResponse> CreateUserAsync(UserRequest request)
        {
            return null;

        }

        public Task<UserResponse> GetUserAsync(string username)
        {
            throw new NotImplementedException();
        }
    }
}
