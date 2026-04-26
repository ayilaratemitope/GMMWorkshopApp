using System.ComponentModel.DataAnnotations;   

namespace GMMWorkshopApp.Models
{
    public class ClassSessions
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; }

        [Required]
        public DateTime SessionDate { get; set; }

        [StringLength(100)]
        public string? TimeSlot { get; set; }

        public int VolunteerId { get; set; }
        public Volunteer? Volunteer { get; set; }

        public ICollection<ClassAttendance> Attendances { get; set; } = new List<ClassAttendance>();

    }
}
