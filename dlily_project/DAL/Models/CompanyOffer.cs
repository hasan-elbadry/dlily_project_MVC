using System.ComponentModel.DataAnnotations;

namespace dlily_project.DAL.Models
{
    public class CompanyOffer : OfferBase
    {
        [Required]
        [StringLength(100)]
        public string OfferName { get; set; } = string.Empty;
    }
}
