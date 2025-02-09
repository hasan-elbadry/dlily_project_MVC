namespace dlily_project.DAL.Models.Users
{
    public class Tourgide : User
    {
        [Range(0, 5)]
        public byte Rating { get; set; }

        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        public double Price { get; set; }

        public IEnumerable<Tourist>? Tourists { get; set; }
    }
}