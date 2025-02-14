namespace dlily_project.DAL.Models.Offers
{
    public class Room
    {
        public int Id { get; set; }

        public string RoomNumber { get; set; }
        public string Images { get; set; }
        public int OfferPresentage { get; set; }
        public string RoomType { get; set; }
        public string BedType { get; set; }
        public int Days { get; set; }
        public double Price { get; set; }
        public double OldPrice { get; set; }

        public string Services { get; set; }
        public string RoomSize { get; set; }
        public string RoomDescription { get; set; }
        public string View {  get; set; }
        public string Facilities { get; set; }

        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
    }
}
