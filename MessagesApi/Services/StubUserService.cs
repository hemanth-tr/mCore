using MessagesApi.Models;

namespace MessagesApi.Services
{
    public class StubUserService : IUserService
    {
        private static List<User> _users;
        public StubUserService()
        {
            if (_users == null)
            {
                _users = new List<User>();
            }
        }

        public async Task<User> CreateUserAsync(User user)
        {
            user.Validate();
            var isAny = _users.Any(u => u.Name == user.Name);
            if (isAny)
            {
                throw new Exception("User exists");
            }

            user.Id = Guid.NewGuid();
            _users.Add(user);
            return user;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return _users;
        }

        public async Task<User> GetUserAsync(Guid id)
        {
            var user = _users.Where(u => u.Id == id).FirstOrDefault();
            return user;
        }
    }
}
