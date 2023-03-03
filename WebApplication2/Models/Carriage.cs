using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class Carriage
{
    public int CarriageId { get; set; }

    public int TrainId { get; set; }

    public int CarriageType { get; set; }

    public string CarriageName { get; set; } = null!;

    public int PlaceCount { get; set; }

    public virtual ICollection<Ticket> Tickets { get; } = new List<Ticket>();

    public virtual Train Train { get; set; } = null!;
}
