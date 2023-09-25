using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TradingWebAppFinalProject.Models
{
    public class ProductCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(9)]
        public string Code {  get; set; }
        [Required]
        [MaxLength(70)]
        public string Name { get; set; }
    }
}
