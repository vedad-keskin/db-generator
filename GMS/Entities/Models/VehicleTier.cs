using System.ComponentModel.DataAnnotations;

namespace GMS.Entities.Models
{
    public class VehicleTier
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string? Description { get; set; }

        // Navigation (optional)
        //public ICollection<Vehicle> Vehicles { get; set; }
    }
}

