namespace TradeSoft.Domain.Exceptions.ProjectCalculationExceptions
{
    public class ProjectNotFoundException : NotFoundException
    {
        public ProjectNotFoundException()
        {
            TitleMessage = "ProjectCalculator Not Found!";
        }
    }
}
