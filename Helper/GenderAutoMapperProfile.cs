using AutoMapper;
using TradingWebAppFinalProject.Data.DTO;

namespace TradingWebAppFinalProject.Helper
{
    public class GenderAutoMapperProfile : Profile
    {
        public GenderAutoMapperProfile()
        {

            CreateMap<Gender, GenderDTO>();
            CreateMap<GenderDTO, Gender>();
        }

    }
}
