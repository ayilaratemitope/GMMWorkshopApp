using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMMWorkshopApp.Models
{
    public class Motorist
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; } = "";

        [Required]
        [StringLength(100)]
        public string LastName { get; set; } = "";

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Phone]
        [StringLength(20, MinimumLength = 10)]
        public string PhoneNumber { get; set; } = string.Empty;

        [StringLength(200)]
        public string? AddressLine1 { get; set; }

        [StringLength(200)]
        public string? AddressLine2 { get; set; }

        [StringLength(100)]
        public string? City { get; set; }

        [StringLength(20)]
        public string? Postcode { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public ICollection<ClassAttendance> ClassAttendances { get; set; } = new List<ClassAttendance>();

    }
}
