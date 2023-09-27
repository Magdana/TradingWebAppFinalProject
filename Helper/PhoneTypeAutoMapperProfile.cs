using AutoMapper;
using TradingWebAppFinalProject.Data.DTO;

namespace TradingWebAppFinalProject.Helper
{
    public class PhoneTypeAutoMapperProfile : Profile
    {
        public PhoneTypeAutoMapperProfile()
        {

            CreateMap<PhoneType, PhoneTypeDTO>();
            CreateMap<PhoneTypeDTO, PhoneType>();
        }
    }


}
