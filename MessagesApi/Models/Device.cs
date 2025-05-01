namespace MessagesApi.Models
{
    public class Device
    {
        public Guid Id { get; set; }
        public DeviceType DeviceType { get; set; }
        public string value { get; set; }
    }
}
