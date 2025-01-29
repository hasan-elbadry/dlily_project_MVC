using System.ComponentModel.DataAnnotations;

namespace dlily_project.DAL.Models
{
    public class Tourgide : User
    {
        [Required]
        [StringLength(100)]
        public string SpokenLanguage { get; set; } = string.Empty;

        [Range(0, 5)]
        public double Rating { get; set; }

        [StringLength(500)]
        public string Description { get; set; } = string.Empty;
    }
}
