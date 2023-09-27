using AutoMapper;
using TradingWebAppFinalProject.Data.DTO;
using TradingWebAppFinalProject.Models;

namespace TradingWebAppFinalProject.Helper
{
    public class ProductAutoMapperProfile : Profile
    {
        public ProductAutoMapperProfile()
        {
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();
        }
    }
}

