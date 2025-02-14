using dlily_project.DAL.Models.Reviews;

namespace dlily_project.DAL.Models.Offers
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Location { get; set; }
        public string Services { get; set; }
        public string Description { get; set; }

        public string HomeImage { get; set; }
        public string OtherImages { get; set; }
        public double Price { get; set; }

        public IEnumerable<Room> Rooms { get; set; }
        public IEnumerable<ReviewHotel> ReviewHotels { get; set; }
    }
}
