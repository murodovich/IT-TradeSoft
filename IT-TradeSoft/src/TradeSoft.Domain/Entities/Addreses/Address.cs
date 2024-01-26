namespace TradeSoft.Domain.Entities.Addreses
{
    public class Address
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
