using AutoMapper;

namespace MyNgAPP.Mappers
{
    public class MapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(mapper =>
            {
                mapper.AddProfile<DataBaseToDtoMappingProfile>();
                mapper.AddProfile<DtoToDatabaseMappingProfile>();
            });
        }
    }
}