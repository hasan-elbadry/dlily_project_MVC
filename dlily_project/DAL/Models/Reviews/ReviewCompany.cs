using dlily_project.DAL.Models.Offers;
using dlily_project.DAL.Models.Users;

namespace dlily_project.DAL.Models.Reviews
{
    public class ReviewCompany
    {
        public int TouristId { get; set; }
        public Tourist Tourist { get; set; }

        public int CompanyId { get; set; }
        public CompanyOffer CompanyOffer { get; set; }
        [Required,StringLength(500)]
        public string Content { get; set; }
    }
}
