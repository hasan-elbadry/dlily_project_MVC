using System.ComponentModel.DataAnnotations;

namespace dlily_project.DAL.Models.Offers
{
    public class BaseOffer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Range(0, 5)]
        public byte Rating { get; set; }

        [Required]
        [StringLength(200)]
        public string Location { get; set; } = string.Empty;

        public byte[] ImageUrl { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive value.")]
        public double Price { get; set; }

        [StringLength(500)]
        public string Description { get; set; } = string.Empty;
    }
}
