using System;
using System.Collections.Generic;

namespace SalesOrderManagementSystem.DBModels;

public partial class GetCustomer
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string Email { get; set; } = null!;
}
