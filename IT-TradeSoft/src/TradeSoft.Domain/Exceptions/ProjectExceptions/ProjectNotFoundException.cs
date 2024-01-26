namespace TradeSoft.Domain.Exceptions.ProjectExceptions
{
    public class ProjectNotFoundException : NotFoundException
    {
        public ProjectNotFoundException()
        {
            TitleMessage = "Project not found";
        }
    }
}
