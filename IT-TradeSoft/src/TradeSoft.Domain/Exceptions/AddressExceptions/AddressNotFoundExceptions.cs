namespace TradeSoft.Domain.Exceptions.AddressExceptions
{
    public class AddressNotFoundExceptions : NotFoundException
    {
        public AddressNotFoundExceptions()
        {
            TitleMessage = "Address not Found!";
        }
    }
}
