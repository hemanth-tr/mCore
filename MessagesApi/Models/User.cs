namespace MessagesApi.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public void Validate()
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentNullException(nameof(Name));
            }
        }
    }
}