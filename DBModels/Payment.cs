using System;
using System.Collections.Generic;

namespace SalesOrderManagementSystem.DBModels;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int? OrderId { get; set; }

    public DateOnly PaymentDate { get; set; }

    public decimal PaymentAmount { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public virtual SalesOrder? Order { get; set; }
}
