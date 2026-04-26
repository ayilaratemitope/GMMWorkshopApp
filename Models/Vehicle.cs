using System.ComponentModel.DataAnnotations;

namespace GMMWorkshopApp.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string RegistrationNumber { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Make { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Model { get; set; } = string.Empty;

        [StringLength(30)]
        public string? VehicleType { get; set; }   // Car, Motorcycle, Scooter

        public int YearOfManufacture { get; set; }

        [StringLength(500)]
        public string? FaultDescription { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select a motorist.")]
        public int MotoristId { get; set; }
        public Motorist? Motorist { get; set; }

        public ICollection<Repair> Repairs { get; set; } = new List<Repair>();

    }
}
