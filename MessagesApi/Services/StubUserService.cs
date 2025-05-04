using AutoMapper;
using MessagesApi.Models;

namespace MessagesApi.Services
{
    public class StubUserService : IUserService
    {
        private static List<User> _users;
        private IMapper _mapper;
        public StubUserService(IMapper mapper)
        {
            if (_users == null)
            {
                _users = new List<User>();
            }
            
            _mapper = mapper;
        }

        public async Task<User> CreateUserAsync(UserModel user)
        {
            user.Validate();
            var isAny = _users.Any(u => u.Name == user.Name);
            if (isAny)
            {
                throw new Exception("User exists");
            }

            var userModel = _mapper.Map<User>(user);
            _users.Add(userModel);
            return userModel;
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
