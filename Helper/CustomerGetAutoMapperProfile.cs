using AutoMapper;
using TradingWebAppFinalProject.Data.DTO;

namespace TradingWebAppFinalProject.Helper
{
    public class CustomerGetAutoMapperProfile : Profile
    {
        public CustomerGetAutoMapperProfile()
        {

            CreateMap<Customer, CustomerGetDTO>();
            CreateMap<CustomerGetDTO, Customer>();
        }
    }
}
