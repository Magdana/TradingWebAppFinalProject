using AutoMapper;
using TradingWebAppFinalProject.Data.DTO;

namespace TradingWebAppFinalProject.Helper
{
    public class PhoneNumbersListAutoMapperProfile : Profile
    {
        public PhoneNumbersListAutoMapperProfile()
        {

            CreateMap<PhoneNumbersList, PhoneNumbersListDTO>();
            CreateMap<PhoneNumbersListDTO, PhoneNumbersList>();
        }

    }
    
}
