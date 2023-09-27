using AutoMapper;
using TradingWebAppFinalProject.Data.DTO;

namespace TradingWebAppFinalProject.Helper
{
    public class RelationshipTypeAutoMapperProfile : Profile
    {
        public RelationshipTypeAutoMapperProfile()
        {

            CreateMap<RelationshipType, RelationshipTypeDTO>();
            CreateMap<RelationshipTypeDTO, RelationshipType>();
        }
    }
}
