using AutoMapper;
using TradingWebAppFinalProject.Data.DTO;

namespace TradingWebAppFinalProject.Helper
{
    public class ProductCategoryAutoMapperProfile : Profile
    {
        public ProductCategoryAutoMapperProfile()
        {

            CreateMap<ProductCategory, ProductCategoryDTO>();
            CreateMap<ProductCategoryDTO, ProductCategory>();
        }
    }
    

}
