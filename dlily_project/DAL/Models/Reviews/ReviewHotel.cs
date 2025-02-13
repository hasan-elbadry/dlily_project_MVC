using dlily_project.DAL.Models.Offers;
using dlily_project.DAL.Models.Users;

namespace dlily_project.DAL.Models.Reviews
{
    public class ReviewHotel
    {
        public int TouristId { get; set; }
        public Tourist Tourist { get; set; }

        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

        [Required, StringLength(500)]
        public string Content { get; set; }
    }
}
