using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TradingWebAppFinalProject.Models;

public class CustomersRelationship
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public RelationshipType RelationshipTypeId { get; set; }
    [Required]
    public Customer StartCustomerId { get; set; }
    [Required]
    public Customer EndCustomerId { get; set; }
    [MaxLength(100)]
    public string? Comment { get; set; }
}
