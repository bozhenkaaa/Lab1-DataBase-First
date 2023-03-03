using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class TrainSchedule
{
    public int PId { get; set; }

    public int TrainId { get; set; }

    public DateTime TrainDate { get; set; }

    public virtual ICollection<Ticket> Tickets { get; } = new List<Ticket>();

    public virtual Train Train { get; set; } = null!;
}
