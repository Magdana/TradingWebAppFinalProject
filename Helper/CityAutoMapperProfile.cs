using AutoMapper;
using TradingWebAppFinalProject.Data.DTO;

namespace TradingWebAppFinalProject.Helper
{
    public class CityAutoMapperProfile : Profile
    {
        public CityAutoMapperProfile()
        {

            CreateMap<City, CityDTO>();
            CreateMap<CityDTO, City>();
        }
    }
}
