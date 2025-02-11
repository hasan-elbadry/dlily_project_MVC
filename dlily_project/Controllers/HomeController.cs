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
        [Authorize]
        public IActionResult Translation()
        {
            return View();
        }
        public IActionResult Index()
        {
            var hotels = _context.HotelOffers.ToList();
            var compaines = _context.CompanyOffers.ToList();
            var tourgide = _context.Tourgides.ToList();



            var model = new HomeViewModel
            {
                HotelOffers = hotels,
                CompanyOffers  = compaines,
                Tourgides = tourgide
            };
            return View(model);
        }
        [Authorize]
        public IActionResult Hotels()
        {
            var hotles = _context.HotelOffers.ToList();

            return View(hotles);
        }

        [Authorize]
        public IActionResult Companies()
        {
            var companies = _context.CompanyOffers.ToList();
            return View(companies);

        }
    
        [Authorize]
        public IActionResult Tourgides()
        {
            var tourgides= _context.Tourgides.ToList();
            return View(tourgides);
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
