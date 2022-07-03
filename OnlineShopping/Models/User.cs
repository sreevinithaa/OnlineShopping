using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Models
{
    public class User
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter first name"), MaxLength(30)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter last name"), MaxLength(30)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter username")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        [Display(Name = "Email")]
        public string Username { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter password")]
         public string Password { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedDate { get; set; }

        public string UserType { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Address"), MaxLength(50)]
        public string Address { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter City"), MaxLength(30)]
        public string City { get; set; }

        [DataType(DataType.PostalCode)]
        [Required(ErrorMessage = "Please enter Zipcode"), MaxLength(4)]
        public int ZipCode { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter State"), MaxLength(30)]
        public string State { get; set; }

    }
}
