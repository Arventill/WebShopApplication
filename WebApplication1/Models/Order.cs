using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        [Required(ErrorMessage = "First name field cannot be empty!")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name field cannot be empty!")]
        [StringLength(100)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Street field cannot be empty!")]
        [StringLength(200)]
        public string Street { get; set; }
        [Required(ErrorMessage = "City field cannot be empty!")]
        [StringLength(100)]
        public string City { get; set;}
        [Required(ErrorMessage = "PostCode field cannot be empty!")]
        [StringLength(8)]
        public string PostCode { get; set; }
        [Required(ErrorMessage = "E-mail field cannot be empty!")]
        [StringLength(200)]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus OrderStatus { get; set; }

        List<OrderPosition> OrderPositions { get; set; }
    }

    public enum OrderStatus
    {
        Preparing,
        Shipped,
        Delivered,
        Canceled
    }
}