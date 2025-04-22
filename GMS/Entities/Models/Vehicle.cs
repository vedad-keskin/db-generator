using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Drawing2D;
using eCommerce.Services.Database;

namespace GMS.Entities.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(20)]
        public string LicensePlate { get; set; }

        [Required]
        [MaxLength(30)]
        public string Color { get; set; }

        [Required]
        [Range(1900, 2100, ErrorMessage = "Year of manufacture must be between 1900 and 2100.")]
        public int YearOfManufacture { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "Seat count must be between 1 and 20.")]
        public int SeatsCount { get; set; }

        //public byte[]? Picture { get; set; }

        [Required]
        public string StateMachine { get; set; }

        [Required]
        public bool PetFriendly { get; set; }

        // FK to Brand
        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        // FK to User (Driver)
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("VehicleTier")]
        public int VehicleTierId { get; set; }
        public VehicleTier VehicleTier { get; set; }
    }
}
