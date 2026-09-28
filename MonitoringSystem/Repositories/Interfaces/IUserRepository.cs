using MonitoringSystem.DTO;

namespace MonitoringSystem.Repositories
{
    public interface IUserRepository
    {
        Task<UserResponse> GetUserAsync(string username);
        Task<UserResponse> CreateUserAsync(UserRequest request);
    }
}
