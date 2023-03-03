using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class Ticket
{
    public int TicketId { get; set; }

    public decimal TicketPrice { get; set; }

    public int PsId { get; set; }

    public int PId { get; set; }

    public int CarriageId { get; set; }

    public DateTime? DateOfBuying { get; set; }

    public int PlaceNumber { get; set; }

    public virtual Carriage Carriage { get; set; } = null!;

    public virtual TrainSchedule PIdNavigation { get; set; } = null!;

    public virtual Passenger Ps { get; set; } = null!;
}
