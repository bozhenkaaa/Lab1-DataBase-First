using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class Passenger
{
    public int PsId { get; set; }

    public string PsSurname { get; set; } = null!;

    public string PsName { get; set; } = null!;

    public string PsPhone { get; set; } = null!;

    public string PsPassport { get; set; } = null!;

    public string? PsEmail { get; set; }

    public virtual ICollection<Ticket> Tickets { get; } = new List<Ticket>();
}
