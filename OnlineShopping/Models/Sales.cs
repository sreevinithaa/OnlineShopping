using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShopping.Models
{
    public class Sales
    {
        [ScaffoldColumn(false)]
        public int SalesId { get; set; }
        [ScaffoldColumn(false)]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [ScaffoldColumn(false)]
        [ForeignKey("User")]
        public int BuyerId { get; set; }

        public int Qantity { get; set; }
        public decimal Price { get; set; }
        [StringLength(10)]
        public string DeliveryType { get; set; }
        [DataType(DataType.Currency)]
        public decimal DeliveryCost { get; set; }
        [StringLength(30)]
        public string SalesStatus { get; set; }
        [ScaffoldColumn(false)]
        public DateTime CreatedDate { get; set; }=DateTime.Now
    }
}
