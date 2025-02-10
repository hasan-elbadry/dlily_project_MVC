using dlily_project.DAL.Models.Reviews;

namespace dlily_project.DAL.Models.Users
{
    public class Tourist : User
    {

        public int? TourgideId { get; set; }
        public Tourgide? Tourgide { get; set; }
        public IEnumerable<ReviewHotel> ReviewHotels { get; set; }
        public IEnumerable<ReviewCompany> ReviewCompanies { get; set; }
    }
}
