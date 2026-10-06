using System;
using System.ComponentModel.DataAnnotations;

namespace EventEase_App.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(100)]
        public string Location { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }
        public List<Attendance> Attendances { get; set; } = new();
    }
}

