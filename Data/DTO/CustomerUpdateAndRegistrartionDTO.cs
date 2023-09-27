using System.ComponentModel.DataAnnotations;

namespace TradingWebAppFinalProject.Data.DTO
{
    public class CustomerUpdateAndRegistrartionDTO
    {

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public GenderDTO? Gender { get; set; }
        public string PersonalNumber { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public CityDTO? City { get; set; }
        public CountryDTO? Country { get; set; }

        public string FullAddres { get; set; } = String.Empty;
        public string Email { get; set; } = null!;
        public PhoneNumbersListDTO? PhoneNumbersList { get; set; }
    }
}
