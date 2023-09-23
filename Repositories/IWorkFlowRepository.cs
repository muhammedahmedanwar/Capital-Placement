using Work.Models;

namespace Work.Repositories
{
    public interface IWorkFlowRepository
    {
        List<WorkFlow> GetAllWorks();
        void Create(WorkFlow workflows);
    }
}
