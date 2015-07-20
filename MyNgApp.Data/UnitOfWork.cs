using System;
using System.Data.Entity;
using System.Threading.Tasks;
using MyNgApp.Data.Repositories;

namespace MyNgApp.Data
{
    internal class UnitOfWork:IUnitOfWork,IDisposable
    {
        private readonly DbContext _context;
        private bool _disposed;
        private IHolidayRepository _holidayRepository;

        public UnitOfWork(DbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }

       

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here. 
            }

            _disposed = true;

            // Free any unmanaged objects here. 
        }

        public IHolidayRepository HolidayRepository
        {
            get
            {
                return _holidayRepository ??
                       (_holidayRepository = new HolidayRepository(_context));
            }
        }

        public virtual void EnableProxyCreation(bool set)
        {
            _context.Configuration.ProxyCreationEnabled = set;
        }

        public virtual int Save()
        {
            return _context.SaveChanges();
        }

        public virtual Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
