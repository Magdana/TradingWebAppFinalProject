namespace TradingWebAppFinalProject.Data.DTO
{
    public class PhoneNumbersListDTO
    {
        public PhoneTypeDTO? PhoneType { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public bool IsMain { get; set; }
    }
}
