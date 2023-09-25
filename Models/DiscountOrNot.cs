using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

    public class DiscountOrNot
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public bool? IsDiscounted { get; set; }
    [Required]
    public bool? IsNotDisqounted { get; set; }
}
