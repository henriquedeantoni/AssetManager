using System.ComponentModel.DataAnnotations;

namespace AssetManager.Entities
{
    public class Asset
    {
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(100, ErrorMessage = "Asset name must be a maximum of 100 characters")]
        public string AssetName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Category name must be a maximum of 50 characters")]
        public string AssetCategory { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "Description must be a maximum text of 500 characters")]
        public string Description { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Serial Number must be a maximum of 100 characters")]
        public string SerialNumber { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }

        [Required]
        public int Cost { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Location must be a maximum of 50 characters")]
        public string Location { get; set; }

        [Required]
        public AssetStatus Status { get; set; } = AssetStatus.Active;

        [Required]
        public Guid? AssignedUserId { get; set; } // Responsável (pode ser nulo)

        [Required]
        public User? AssignedUser { get; set; }
    }

    public enum AssetStatus
    {
        Active,
        Inactive,
        InMaintenance,
        Discarded
    }   
}
