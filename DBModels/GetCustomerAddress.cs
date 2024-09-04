using System;
using System.Collections.Generic;

namespace SalesOrderManagementSystem.DBModels;

public partial class GetCustomerAddress
{
    public int CustomerId { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }
}
