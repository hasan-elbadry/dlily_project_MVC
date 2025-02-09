using dlily_project.DAL.Models.Offers;

namespace dlily_project.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var hotels = _context.HotelOffers.ToList();
            return View(hotels);
        }

        public IActionResult Hotels()
        {
            var hotles = _context.HotelOffers.ToList();

            return View(hotles);
        }

        public IActionResult Companies()
        {
            return View();

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
