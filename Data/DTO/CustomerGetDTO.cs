namespace TradingWebAppFinalProject.Data.DTO
{
    public class CustomerGetDTO
    {
        public string? FirstName { get; set; } = null;

        public string? LastName { get; set; } = null;
        public string? PersonalNumber { get; set; } = null;
        public DateTime BirthDate { get; set; }
        public PhoneNumbersListDTO? PhoneNumbers { get; set; }
        public PhoneTypeDTO? PhoneType { get; set; }
        public CityDTO? City { get; set; }
        public CountryDTO? Country { get; set; }
        public string? FullAddres { get; set; }
        public PhoneNumbersListDTO? PhoneNumbersList { get; set; }
        public string Email { get; set; } = null!;

        //public CustomersRelationship CustomersRelative { get; set; }
        public RelationshipTypeDTO? RelationshipType { get; set; }
        public ICollection<OrderDTO>? Orders { get; set; }
        public int OrderCount
        {
            get { return Orders?.Count ?? 0; }
          
        }
    }
}
