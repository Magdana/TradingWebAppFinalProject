using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TradingWebAppFinalProject.Models
{
    public class PhoneNumbersList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {  get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "Minimum length is 2 characters.")]
        [MaxLength(50, ErrorMessage = "Maximum length is 50 characters.")]
        public string PrimaryPhoneNumber { get; set; }
        [MinLength(4, ErrorMessage = "Minimum length is 2 characters.")]
        [MaxLength(50, ErrorMessage = "Maximum length is 50 characters.")]
        public string SecondPhoneNumber { get; set; }
       
    }
}
