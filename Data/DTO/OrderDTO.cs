using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TradingWebAppFinalProject.Data.DTO
{
    public class OrderDTO
    {
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }
        public CustomerGetDTO Customer { get; set; }
        public int TotalAmount { get; set; }
    }
}
