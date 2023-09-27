using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TradingWebAppFinalProject.Models;
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
    public Product Product { get; set; }
    [Required]
    public Supplier Supplier { get; set; } = null!;
    [Required]
    public Unit Unit { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public DateTime ExpiryDate { get; set; }
    [Required]
    public double UnitPrice { get; set; }
    [Required]
    public double RealizationPrice { get; set; }

}
