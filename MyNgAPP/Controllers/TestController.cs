using System.Collections.Generic;
using System.Web.Http;
using AutoMapper;
using MyNgApp.Data.Models;
using MyNgApp.Service;
using MyNgAPP.ViewModels;

namespace MyNgAPP.Controllers
{
    [RoutePrefix("api/test")]
    public class TestController : ApiController
    {
        private readonly IHolidayService _holidayService;

        public TestController(IHolidayService holidayService)
        {
            _holidayService = holidayService;
        }

        public IHttpActionResult Get()
        {
            var holidays = _holidayService.GetAllHolidays();

            var holidayDtos = Mapper.Map<List<HolidayDTO>>(holidays);
            return Ok(
               new
               {
                   data = holidayDtos
               }
          );
        }
    }
}
