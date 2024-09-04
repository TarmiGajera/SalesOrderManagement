using System;
using System.Collections.Generic;

namespace SalesOrderManagementSystem.DBModels;

public partial class GetProduct
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int StockQuantity { get; set; }
}
