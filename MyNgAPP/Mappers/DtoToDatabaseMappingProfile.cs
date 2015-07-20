
using AutoMapper;

namespace MyNgAPP.Mappers
{
    public class DtoToDatabaseMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DtoToDatabaseMappingProfile"; }
        }

         protected override void Configure()
        {
        }
    }
}