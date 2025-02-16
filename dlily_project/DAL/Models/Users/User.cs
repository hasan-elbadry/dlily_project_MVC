using dlily_project.DAL.Enum;

namespace dlily_project.DAL.Models.Users
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(300)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Phone]
        [StringLength(15)]
        public string Phone { get; set; } = string.Empty;

        [Required]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters.")]
        public string Password { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Address { get; set; } = string.Empty;

        [Required]
        public Gender Gender { get; set; } = Gender.Unknown;

        [Required]
        [StringLength(100)]
        public string SpokenLanguage { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string FeedBack { get; set; } = string.Empty;

        public byte[] ProfilePicture { get; set; } = Array.Empty<byte>();
    }
}



