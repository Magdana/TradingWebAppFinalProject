using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TradingWebAppFinalProject.Models;

public class CustomersRelationship
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public RelationshipType RelationshipType { get; set; }

    [ForeignKey("StartCustomerId ")]
    public Customer? StartCustomer { get; set; }

    [ForeignKey("EndCustomerId ")]
    public Customer? EndCustomer { get; set; }
    [MaxLength(100)]
    public string? Comment { get; set; }
}
