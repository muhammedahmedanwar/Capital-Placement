using Work.Data;
using Work.Models;

namespace Work.Repositories
{
    public class FinalPageRepository : IFinalPageRepository
    {
        private readonly ApplicationDbContext _db;

        public FinalPageRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<ProgramDetail> GetAllDetails()
        {
            try
            {
                List<ProgramDetail> list = (from dbs in _db.ProgramDetails
                                            select dbs).ToList();
                return list;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return null;
            }
        }

        public List<WorkFlow> GetAllWorkFlows()
        {
            try
            {
                List<WorkFlow> list = (from dbs in _db.WorkFlows
                                       select dbs).ToList();
                return list;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return null;
            }
        }

        public List<AppForm> GetAllAppForms()
        {
            try
            {
                List<AppForm> list = (from dbs in _db.AppForms
                                            select dbs).ToList();
                return list;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return null;
            }
        }
    }
}
