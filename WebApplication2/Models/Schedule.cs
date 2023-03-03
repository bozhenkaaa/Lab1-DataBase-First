using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models;

public partial class Schedule
{
    [Required(ErrorMessage = "Поле не повинне бути порожнім!")]
    public int ScheduleId { get; set; }
    [Required(ErrorMessage ="Поле не повинне бути порожнім!")]
    [Display(Name= "Станція№")]
    public int StationNumber { get; set; }
    [Required(ErrorMessage = "Поле не повинне бути порожнім!")]
    [Display(Name = "Назва станції")]
    public string StationName { get; set; } = null!;

    public virtual ICollection<Train> Trains { get; } = new List<Train>();
}
