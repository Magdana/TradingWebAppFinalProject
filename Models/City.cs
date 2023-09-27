using System.ComponentModel.DataAnnotations;
public class City
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    public Country ContainingCountry { get; set; }
}
