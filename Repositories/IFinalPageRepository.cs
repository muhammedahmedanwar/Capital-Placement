using Work.Models;

namespace Work.Repositories
{
    public interface IFinalPageRepository
    {
        List<ProgramDetail> GetAllDetails();
        List<WorkFlow> GetAllWorkFlows();
        List<AppForm> GetAllAppForms();
    }
}
