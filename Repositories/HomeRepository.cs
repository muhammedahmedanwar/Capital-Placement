using Work.Data;
using Work.Models;

namespace Work.Repositories
{
    public class HomeRepository : IHomeRepository
    {
        private readonly ApplicationDbContext _db;

        public HomeRepository(ApplicationDbContext db)
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

        public void Create(ProgramDetail detail)
        {
            _db.ProgramDetails.Add(detail);
            _db.SaveChanges();
        }
    }
}
