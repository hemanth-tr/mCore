using MessagesApi.Models;

namespace MessagesApi.Services
{
    public class StubMessagesService : IMessageService
    {
        private static List<Message> _Messages {  get; set; }
        public StubMessagesService()
        {
            if (_Messages == null)
            {
                _Messages = new List<Message>();
            }
        }
        public async Task AddMessagesAsync(Message message)
        {
            message.Validate();
            message.Id = Guid.NewGuid();
            _Messages.Add(message);
        }

        public async Task<IEnumerable<Message>> GetMessagesAsync(Guid id)
        {
            var messages = _Messages.Where(m => m.From.Equals(id));
            return messages;
        }
    }
}
