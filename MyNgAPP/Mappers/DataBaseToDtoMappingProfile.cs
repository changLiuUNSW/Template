using AutoMapper;
using MyNgApp.Data.Models;
using MyNgAPP.ViewModels;

namespace MyNgAPP.Mappers
{
    public class DataBaseToDtoMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DataBaseToDtoMappingProfile"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Holiday, HolidayDTO>();
        }
    }
}