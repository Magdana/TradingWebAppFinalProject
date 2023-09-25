using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TradingWebAppFinalProject.Models;

public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [StringLength(9)]
    public string Code { get; set; } = null!;
    [Required]
    [MaxLength(100)]
    [MinLength(2, ErrorMessage = "Minimum length is 2 characters.")]
    public string Name { get; set; } = null!;
    [Required]
    public ProductCategory CategoryId { get; set; }

    public virtual ICollection<Warehouse> Warehouses { get; set; } = new List<Warehouse>();
}
