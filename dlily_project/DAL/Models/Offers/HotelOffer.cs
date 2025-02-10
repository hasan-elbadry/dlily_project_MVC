using dlily_project.DAL.Models.Reviews;

namespace dlily_project.DAL.Models.Offers
{
    public class HotelOffer : BaseOffer
    {
        public byte[] ImageUrl { get; set; }
        public IEnumerable<ReviewHotel> ReviewHotels { get; set; }
    }
}
