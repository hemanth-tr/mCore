namespace MessagesApi.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public Guid From { get; set; }
        public Guid To { get; set; }
        public string MessageText { get; set; }
        public DateTime Date { get; set; }
        public void Validate()
        {
            if (this.From == Guid.Empty)
            {
                throw new ArgumentException(nameof(From));
            }

            if (this.To == Guid.Empty)
            {
                throw new ArgumentException(nameof(To));
            }

            if (this.MessageText == null)
            {
                throw new ArgumentNullException(nameof(MessageText));
            }
        }
    }
}
