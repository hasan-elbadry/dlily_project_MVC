using System.ComponentModel.DataAnnotations;

namespace dlily_project.DAL.Models
{
    public class TouristPlaces
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [StringLength(200)]
        public string Location { get; set; } = string.Empty;

        public TimeSpan OpenAt { get; set; }
        public TimeSpan CloseAt { get; set; }

        [Range(0, 5)]
        public byte Rating { get; set; }

        [StringLength(200)]
        public string Category { get; set; } = string.Empty;

        [Required]
        public double EntryFee { get; set; }

        public string ImageUrl { get; set; } = string.Empty;
    }
}
