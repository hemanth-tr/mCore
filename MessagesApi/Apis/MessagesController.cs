using MessagesApi.Models;
using MessagesApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MessagesApi.Apis
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private IMessageService _messageService;
        public MessagesController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet]
        public async Task<IEnumerable<Message>> GetAsync(Guid id)
        {
            var messages = await _messageService.GetMessagesAsync(id).ConfigureAwait(false);
            return messages;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Message message)
        {
            message.Validate();
            await _messageService.AddMessagesAsync(message).ConfigureAwait(false);
            return Ok();
        }
    }
}
