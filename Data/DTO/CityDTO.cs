using System.ComponentModel.DataAnnotations;

namespace TradingWebAppFinalProject.Data.DTO
{
    public class CityDTO
    {
        public string Name { get; set; }
        public CountryDTO ContainingCountry { get; set; }
    }
}
