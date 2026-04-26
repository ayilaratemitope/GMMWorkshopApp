using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMMWorkshopApp.Models
{
    public class Repair
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Repair Date")]
        public DateTime RepairDate { get; set; } = DateTime.Today;

        [Required]
        [StringLength(500)]
        [Display(Name = "Repair Description")]
        public string RepairDescription { get; set; } = string.Empty;

        [Range(0, 1000)]
        [Display(Name = "Labour Hours")]
        public decimal LabourHours { get; set; }

        [NotMapped]
        [Display(Name = "Total Parts Cost")]
        public decimal TotalPartsCost => Parts?.Sum(p => p.TotalCost) ?? 0;

        [NotMapped]
        [Display(Name = "Total Repair Cost")]
        public decimal TotalRepairCost => TotalPartsCost;
        [Range(1, int.MaxValue, ErrorMessage = "Please select a vehicle.")]
        public int VehicleId { get; set; }

        public Vehicle? Vehicle { get; set; }

        public ICollection<Part> Parts { get; set; } = new List<Part>();
    }
}