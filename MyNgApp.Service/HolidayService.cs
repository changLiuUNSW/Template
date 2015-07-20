using System.Collections.Generic;
using MyNgApp.Data;
using MyNgApp.Data.Models;

namespace MyNgApp.Service
{
    public interface IHolidayService
    {
        IEnumerable<Holiday> GetAllHolidays();
    }

    internal class HolidayService : IHolidayService
    {

        private readonly IUnitOfWork _unitOfWork;
        public HolidayService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Holiday> GetAllHolidays()
        {
            return _unitOfWork.HolidayRepository.Get();
        }
    }
}
