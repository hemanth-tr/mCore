using MessagesApi.Models;

namespace MessagesApi.Services
{
    public interface IMessageService
    {
        Task<IEnumerable<Message>> GetMessagesAsync(Guid id);
        Task AddMessagesAsync(Message message);
    }
}
