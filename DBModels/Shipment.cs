using System;
using System.Collections.Generic;

namespace SalesOrderManagementSystem.DBModels;

public partial class Shipment
{
    public int ShipmentId { get; set; }

    public int? OrderId { get; set; }

    public DateOnly ShipmentDate { get; set; }

    public string? Carrier { get; set; }

    public string? TrackingNumber { get; set; }

    public string ShipmentStatus { get; set; } = null!;

    public virtual SalesOrder? Order { get; set; }
}
