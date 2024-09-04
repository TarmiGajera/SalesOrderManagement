using System;
using System.ComponentModel.DataAnnotations;
namespace SalesOrderManagementSystem.DBModels
{
    public class SalesOrderModel
    {
        public int OrderID { get; set; }

        [Required]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero.")]
        public decimal Price { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        [Required]
        public string Status { get; set; }
    }

    public enum OrderStatus
    {
        Pending,
        Shipped,
        Delivered,
        Canceled
    }
}
