namespace TradeSoft.Domain.Exceptions.ImageExceptions
{
    public class ImageNotValidExceptions : NotFoundException
    {
        public ImageNotValidExceptions()
        {
            TitleMessage = "Image not Valid";
        }
    }
}
