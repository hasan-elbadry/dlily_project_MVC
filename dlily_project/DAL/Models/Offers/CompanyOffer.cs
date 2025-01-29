using dlily_project.DAL.Models.Reviews;
using System.ComponentModel.DataAnnotations;

namespace dlily_project.DAL.Models.Offers
{
    public class CompanyOffer : BaseOffer
    {
        public IEnumerable<ReviewHotel> ReviewHotels { get; set; }
    }
}