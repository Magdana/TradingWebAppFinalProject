using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TradingWebAppFinalProject.Models;


public class CustomerPhoneNumber
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public PhoneType PhoneTypeId { get; set; }
    [Required]
    public PhoneNumbersList PhoneNumber { get; set; } = null!;
    [Required]
    public Customer CustomerId { get; set; }

}
