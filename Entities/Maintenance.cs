using System.ComponentModel.DataAnnotations;

namespace AssetManager.Entities
{
    public class Maintenance
    {
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid AssetId { get; set; }

        [Required]
        public Asset Asset { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "Maintenance description must be a maximum text of 500 characters")]
        public string MaintenanceDescription { get; set; }

    }
}
