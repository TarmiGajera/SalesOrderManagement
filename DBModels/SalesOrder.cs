using System;
using System.Collections.Generic;

namespace SalesOrderManagementSystem.DBModels;

public partial class SalesOrder
{
    public int OrderId { get; set; }

    public int? CustomerId { get; set; }

    public DateOnly OrderDate { get; set; }

    public string Status { get; set; } = null!;

    public decimal TotalAmount { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();
}
