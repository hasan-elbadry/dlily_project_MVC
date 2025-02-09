using dlily_project.DAL.Models.Offers;

namespace dlily_project.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hotels()
        {
            return View();
        }

        public IActionResult Companies()
        {
            var companies = new List<CompanyOffer>
                {
                    new CompanyOffer
                    {
                        Name = "TechNova Solutions",
                        Rating = 5,
                        Location = "San Francisco, USA",
                        Price = 299.99,
                        Description = "Leading provider of AI-driven enterprise solutions",
                        ImageUrl = new byte[0] // Placeholder, in a real app use a real image source
                    },
                    new CompanyOffer
                    {
                        Name = "Global Finance Corp",
                        Rating = 4,
                        Location = "London, UK",
                        Price = 199.99,
                        Description = "Global financial services provider",
                        ImageUrl = new byte[0]
                    }
            };



            return View(companies);

        }
    

        public IActionResult Tourgides()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
