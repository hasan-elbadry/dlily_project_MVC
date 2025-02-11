namespace dlily_project.DAL.Models.Offers
{
    public class Hotel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }
        public string Image { get; set; }

        public double Price { get; set; }

        public int Rating { get; set; }
    }
}
