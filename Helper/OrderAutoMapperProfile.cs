using AutoMapper;
using TradingWebAppFinalProject.Data.DTO;

namespace TradingWebAppFinalProject.Helper
{
    public class OrderAutoMapperProfile : Profile
    {
        public OrderAutoMapperProfile()
        {

            CreateMap<Order, OrderDTO>();
            CreateMap<OrderDTO, Order>();
        }

    }
    
}
