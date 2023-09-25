using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TradingWebAppFinalProject.Models
{
    public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(9)]
        public string CompanyCode { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(2, ErrorMessage ="Name contains minimum 2 symbols!")]
        public string CompanyName {  get; set; }
        [Required]
        [MaxLength(70)]
        public string ContactFullName { get; set; }
        [Required]
        public City CityId { get; set; }
        [Required]
        public Country CountryId { get; set; }
        public int Phone {  get; set; }
        public int Fax { get; set; }
        public string WebSite { get; set;}

    }
}
