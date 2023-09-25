using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public  class Order
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public DateTime OrderDate { get; set; }
    [Required]
    [MaxLength(9)]
    public int OrderNumber { get; set; }
    [Required]
    public Customer CustomerId { get; set; }
    [Required]
    public int TotalAmount { get; set; }
}
