using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TradingWebAppFinalProject.Data.DTO;

namespace TradingWebAppFinalProject.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(9)]
        public string Code { get; set; } = null!;
        [MaxLength(100)]
        [MinLength(2, ErrorMessage = "Minimum length is 2 characters.")]
        public string Name { get; set; } = null!;
        public ProductCategory? Category { get; set; }
        public double Price { get; set; }
        public Unit? Unit { get; set; }
        public int Quantity { get; set; }
        public double RealizationPrice { get; set; }
        public bool Discount { get; set; }
        public double? DiscountAmount { get; set; }
        public DateTime? ManufacturingDate { get; set; }
        public DateTime? ShelfLife { get; set; }
        //[NotMapped]
        //public DateTime? ExpiryDate
        //{
        //    get
        //    {
        //        return ManufacturingDate + ShelfLife;
        //    }
        //}
    }
}