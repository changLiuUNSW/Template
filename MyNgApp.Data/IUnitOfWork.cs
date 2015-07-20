using System.Threading.Tasks;
using MyNgApp.Data.Repositories;

namespace MyNgApp.Data
{
    public interface IUnitOfWork
    {
        IHolidayRepository HolidayRepository { get; }

        void EnableProxyCreation(bool set);
        int Save();
        Task<int> SaveAsync();
    }
}
