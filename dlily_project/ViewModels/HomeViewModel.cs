using dlily_project.DAL.Models.Offers;

namespace dlily_project.ViewModels
{
    public class HomeViewModel
    {
        public List<Hotel> Hotels { get; set; }
        public List<CompanyOffer> CompanyOffers{ get; set; }
        public List<Tourgide> Tourgides { get; set; }
    }
}
