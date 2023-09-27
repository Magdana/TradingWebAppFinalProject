using AutoMapper;
using TradingWebAppFinalProject.Data.DTO;

namespace TradingWebAppFinalProject.Helper
{
    public class CustomerUpdateAndRegistrartionAutoMapperProfile : Profile
    {
        
            public CustomerUpdateAndRegistrartionAutoMapperProfile()
            {
                CreateMap<Customer, CustomerUpdateAndRegistrartionDTO>();
                CreateMap<CustomerUpdateAndRegistrartionDTO, Customer>();
            }
        
    }
}
