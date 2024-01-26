namespace TradeSoft.Domain.Exceptions.QuestionExceptions
{
    public class QuestionNotFoundException : NotFoundException
    {
        public QuestionNotFoundException()
        {
            TitleMessage = "Question Not Found!";
        }
    }
}
