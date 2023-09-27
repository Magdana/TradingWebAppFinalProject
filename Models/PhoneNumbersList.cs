using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TradingWebAppFinalProject.Models
{
    public class PhoneNumbersList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MinLength(4, ErrorMessage = "Minimum length is 2 characters.")]
        [MaxLength(50, ErrorMessage = "Maximum length is 50 characters.")]
        public PhoneType? PhoneType { get; set; }
        [StringLength(9)]
        public string PhoneNumber { get; set; }
        //public Customer? Customer { get; set; }
        public bool IsMain {  get; set; }

    }
}
