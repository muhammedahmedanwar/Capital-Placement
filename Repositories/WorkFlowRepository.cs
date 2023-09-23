using Work.Data;
using Work.Models;

namespace Work.Repositories
{
    public class WorkFlowRepository : IWorkFlowRepository
    {
        private readonly ApplicationDbContext _db;

        public WorkFlowRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<WorkFlow> GetAllWorks()
        {
            try
            {
                List<WorkFlow> workflows = (from dbs in _db.WorkFlows
                                       select dbs).ToList();
                return workflows;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return null;
            }
        }

        public void Create(WorkFlow workflows)
        {
            _db.WorkFlows.Add(workflows);
            _db.SaveChanges();
        }
    }
}
