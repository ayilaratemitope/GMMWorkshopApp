using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMMWorkshopApp.Models
{
    public class Part
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Part Name field is required.")]
        [StringLength(100)]
        public string PartName { get; set; } = string.Empty;

        [Required]
        public PartCategory PartCategory { get; set; }  //Enum for part category
        
        [Range(0, 1000, ErrorMessage = "The field quantity used must be between 1 and 1000.")]
        public int QuantityUsed { get; set; }

        [Range(0, 100000)]
        public decimal UnitCost { get; set; }

        public decimal TotalCost => QuantityUsed * UnitCost;

        [Range(1, int.MaxValue, ErrorMessage = "Please select a repair.")]
        public int RepairId { get; set; }

        public Repair? Repair { get; set; }
    }
}