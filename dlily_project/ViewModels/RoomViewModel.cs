namespace dlily_project.ViewModels
{
    public class RoomViewModel
    {
            public string RoomNumber { get; set; }
            public List<string> Images { get; set; }
            public int OfferPresentage { get; set; }
            public string RoomType { get; set; }
            public string BedType { get; set; }
            public int Days { get; set; }
            public double Price { get; set; }
            public double OldPrice { get; set; }

            public List<List<string>> Services { get; set; }
            public string RoomSize { get; set; }
            public string RoomDescription { get; set; }
            public string View { get; set; }
            public List<string> Facilities { get; set; }
    }
}
