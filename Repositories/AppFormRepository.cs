using Work.Data;
using Work.Models;

namespace Work.Repositories
{
    public class AppFormRepository: IAppFormRepository
    {
        private readonly ApplicationDbContext _db;

        public AppFormRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<AppForm> GetAllDetails()
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

        public void Create(AppForm detail)
        {
            _db.AppForms.Add(detail);
            _db.SaveChanges();
        }
    }
}
