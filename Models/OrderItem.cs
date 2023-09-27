using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class OrderItem
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public Order Order { get; set; }
    [Required]
    public Product Product { get; set; }
    [Required]
    public double UnitPrice { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public bool IsDiscounted { get; set; }

    public double? DiscountPrice { get; set; }
    [NotMapped] 
    public double? PriceWithDiscount
    {
        get
        {
            return UnitPrice-DiscountPrice;
        }
    }
   
}
