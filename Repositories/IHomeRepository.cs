using Work.Models;

namespace Work.Repositories
{
    public interface IHomeRepository
    {
        List<ProgramDetail> GetAllDetails();
        void Create(ProgramDetail detail);
    }
}
