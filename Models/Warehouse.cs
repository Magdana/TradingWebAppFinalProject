using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TradingWebAppFinalProject.Models;

public class Warehouse
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required] 
    public DateTime OperationDate { get; set; }
    [Required]
    [StringLength(15)]
    public string DocNumber { get; set; } = null!;
    [Required]
    public Product ProductId { get; set; }
    [Required]
    public Supplier SupplierId { get; set; } = null!;
    [Required]
    public Unit UnitId { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public DateTime ExpiryDate { get; set; }
    [Required]
    public double UnitPrice { get; set; }
    [Required]
    public double RealizationPrice { get; set; }

    public virtual Product Product { get; set; } = null!;
}
