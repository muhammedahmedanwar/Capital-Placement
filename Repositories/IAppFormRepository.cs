using Work.Models;

namespace Work.Repositories
{
    public interface IAppFormRepository
    {
        List<AppForm> GetAllDetails();
        void Create(AppForm appform);
    }
}
