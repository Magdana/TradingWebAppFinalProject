using AutoMapper;
using TradingWebAppFinalProject.Data.DTO;

namespace TradingWebAppFinalProject.Helper
{
    public class UnitAutoMapperProfile : Profile
    {
        public UnitAutoMapperProfile()
        {

            CreateMap<Unit, UnitDTO>();
            CreateMap<UnitDTO, Unit>();
        }
    }
}
