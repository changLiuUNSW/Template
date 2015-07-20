using System.Data.Entity;
using MyNgApp.Data.Infrastructure;
using MyNgApp.Data.Models;

namespace MyNgApp.Data.Repositories
{
    public interface IHolidayRepository:IRepository<Holiday>
    {
       
    }

    internal class HolidayRepository : Repository<Holiday>,IHolidayRepository
    {
        public HolidayRepository(DbContext dbContext) : base(dbContext)
        {
        }

     
    }
}
