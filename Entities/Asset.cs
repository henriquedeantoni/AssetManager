using System.ComponentModel.DataAnnotations;

namespace AssetManager.Entities
{
    public class Asset
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Asset name must be a maximum of 100 characters")]
        public string AssetName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Category name must be a maximum of 40 characters")]
        public string AssetCategory { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Serial Number must be a maximum of 100 characters")]
        public string SerialNumber { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }

        [Required]
        public int Cost { get; set; }

        [Required]
        public string Location { get; set; }
    }
}
