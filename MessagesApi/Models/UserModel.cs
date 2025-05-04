namespace MessagesApi.Models
{
    public class UserModel
    {
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