using System.ComponentModel.DataAnnotations.Schema;

namespace TradingWebAppFinalProject.Data.DTO
{
    public class ProductDTO
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public ProductCategoryDTO? Category { get; set; }
        public double Price { get; set; }
        public UnitDTO? Unit { get; set; }
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
