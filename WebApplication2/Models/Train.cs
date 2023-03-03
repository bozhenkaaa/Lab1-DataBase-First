using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models;

public partial class Train
{
    [Required]
    public int TrainId { get; set; }
    [Display(Name = "Місто відправлення")]
    public string TrainDeparture { get; set; } = null!;
    [Display(Name = "Місто прибуття")]
    public string TrainDestination { get; set; } = null!;
    [Display(Name = "Час відправлення")]
    public TimeSpan TrainTimeOfDep { get; set; }
    [Display(Name = "Час прибуття")]
    public TimeSpan TrainTimeOfStop { get; set; }
    [Display(Name = "Тип потяга")]
    public string TrainType { get; set; } = null!;
    [Display(Name = "Розклад№")]
    public int ScheduleId { get; set; }

    public virtual ICollection<Carriage> Carriages { get; } = new List<Carriage>();

    public virtual Schedule Schedule { get; set; } = null!;

    public virtual ICollection<TrainSchedule> TrainSchedules { get; } = new List<TrainSchedule>();
}
