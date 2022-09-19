using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace Hotel.Web.Models
{
    [Table(name: "Customers")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int CustomerId { get; set; }

        [Required(ErrorMessage = "{0} cannot be empty!")]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Please Enter Valid Name")]
        [Display(Name = "Name of the Customer")]

        public string CustomerName { get; set; }


        [Required(ErrorMessage = "{0} cannot be empty")]
        [Display(Name = "Address")]
        [Column(TypeName = "varchar(50)")]
        public string Address { get; set; }

        [Display(Name = "Phone Number:")]
        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Please Enter Valid Mobile Number.")]

        public string PhoneNumber { get; set; }
        #region Navigation Properties to the OrderDetail Model
        public ICollection<OrderDetails> OrderDetails { get; set; }
        #endregion
    }
}