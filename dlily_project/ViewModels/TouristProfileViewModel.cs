namespace dlily_project.ViewModels
{
    public class TouristProfileViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Username must be at least 3 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        [StringLength(300)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Invalid phone number.")]
        [StringLength(15)]
        public string Phone { get; set; }

        public string? CurrentPassword { get; set; }

        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters.")]
        public string? NewPassword { get; set; }

        [Compare("NewPassword", ErrorMessage = "Passwords do not match")]
        public string? ConfirmNewPassword { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please select a gender.")]
        public Gender Gender { get; set; }

        [Required]
        [StringLength(100)]
        public string SpokenLanguage { get; set; } = string.Empty;

        [Display(Name = "Profile Picture")]
        public byte[]? ShowProfilePicture { get; set; }

        public IFormFile? NewProfilePicture { get; set; }
    }
}
