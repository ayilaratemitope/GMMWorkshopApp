using System.ComponentModel.DataAnnotations;

namespace GMMWorkshopApp.Models
{
    public class Volunteer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public bool IsLecturer { get; set; }

        public ICollection<ClassSessions> ClassesDelivered { get; set; } = new List<ClassSessions>();

        public string FullName => $"{FirstName} {LastName}";
    }
}