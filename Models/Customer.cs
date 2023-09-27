using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TradingWebAppFinalProject.Models;
public class Customer
{
    //[Key]
    //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [MaxLength(50, ErrorMessage = "Maximum length is 50 characters.")]
    [MinLength(2, ErrorMessage = "Minimum length is 2 characters.")]
    public string FirstName { get; set; } = null!;
    [Required]
    [MaxLength(50, ErrorMessage = "Maximum length is 50 characters.")]
    [MinLength(2, ErrorMessage = "Minimum length is 2 characters.")]
    public string LastName { get; set; } = null!;
    public Gender? Gender { get; set; }
    [Required]
    [StringLength(11, ErrorMessage = "length is 11 characters.")]
    public string PersonalNumber { get; set; } = null!;
    [Required]
    [MinimumAge(18, ErrorMessage = "Customer must  be at least 18 years old.")]
    public DateTime BirthDate { get; set; }
    
    public City? City { get; set; }
    public Country? Country { get; set; }
    [EmailAddress(ErrorMessage = "Invalid email address!")]
    public string? FullAddres {  get; set; }
    //public PhoneType PhoneType { get; set; }
    public PhoneNumbersList? PhoneNumbersList { get; set; }
    public string Email { get; set; } = null!;
    public RelationshipType? RelationshipType { get; set; }
    public ICollection<Order>? Orders { get; set; }
}
