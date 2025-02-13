using dlily_project.DAL.Models.Offers;
using dlily_project.DAL.Models.Reviews;

namespace dlily_project.ViewModels
{
    public class HotelViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Location { get; set; }
        public List<string> Services { get; set; }
        public string Description { get; set; }

        public string HomeImage { get; set; }
        public List<string> OtherImages { get; set; }
        public double Price { get; set; }
    }
}
