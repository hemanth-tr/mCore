using MessagesApi.Models;

namespace MessagesApi.Services
{
    public interface IUserService
    {
        Task<User> CreateUserAsync(UserModel user);
        Task<User> GetUserAsync(Guid id);
        Task<IEnumerable<User>> GetAllUsersAsync();
    }
}
