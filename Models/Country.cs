using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Country
{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    public int CountryId { get; set; }
    [Required]
    [StringLength(9)]
    public string CountryCode { get; set; } = "";
    [Required]
    [MaxLength(70)]
    public string CountryName { get; set; } = "";
}


