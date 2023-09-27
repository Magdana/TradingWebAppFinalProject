using AutoMapper;
using TradingWebAppFinalProject.Data.DTO;

namespace TradingWebAppFinalProject.Helper
{
    public class CountryAutoMapperProfile : Profile
    {
        public CountryAutoMapperProfile()
        {

            CreateMap<Country, CountryDTO>();
            CreateMap<CountryDTO, Country>();
        }
    }
}
