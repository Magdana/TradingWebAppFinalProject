using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class OrderItem
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public Order OrderId { get; set; }
    [Required]
    public Product ProductId { get; set; }
    [Required]
    public double UnitPrice { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public DiscountOrNot IsDiscounted { get; set; }

    public double DiscountPrice { get; set; }
}
