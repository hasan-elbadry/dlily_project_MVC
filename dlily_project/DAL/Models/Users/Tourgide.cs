namespace dlily_project.DAL.Models.Users
{
    public class Tourgide : User
    {
        [Required]
        [StringLength(100)]
        public string SpokenLanguage { get; set; } = string.Empty;

        [Range(0, 5)]
        public byte Rating { get; set; }

        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        public IEnumerable<Tourist>? Tourists { get; set; }
    }
}