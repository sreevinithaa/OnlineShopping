using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShopping.Models
{
    public class Product
    {
        [ScaffoldColumn(false)]
        public int ProductId { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter product name"), MaxLength(50)]
        public string Name { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter description")]
        public string Description { get; set; }

        
        [Required(ErrorMessage = "Please enter quantity")]
        public int Qantity { get; set; }

        [StringLength(30)]
        public string Category { get; set; }    
        public bool IsUsed { get; set; }=false; 

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Please enter proce")]
        public decimal Price { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedDate { get; set; }=DateTime.Now;

        [ScaffoldColumn(false)]
        public bool IsAvailable { get; set; }=true;

        [ForeignKey("User")]
        public int SellerId { get; set; }

        public ICollection<Sales> Sales { get; set; }
    }
}
