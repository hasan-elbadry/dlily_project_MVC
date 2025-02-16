using dlily_project.DAL.Models.Offers;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Text.Json;

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
            var hotels = _context.Hotels.ToList();
            var compaines = _context.CompanyOffers.ToList();
            var tourgide = _context.Tourgides.ToList();
            var touristPlaces = _context.TouristPlaces.ToList();




            var model = new HomeViewModel
            {
                Hotels = hotels,
                CompanyOffers  = compaines,
                Tourgides = tourgide,
                TouristPlaces = touristPlaces
            };
            return View(model);
        }


      ////  var hotels = _context.Hotels
      //.ToList() // Move data into memory
      //.Select(x => new HotelViewModel
      //{
      //    HomeImage = x.HomeImage,
      //    Description = x.Description,
      //    Id = x.Id,
      //    Location = x.Location,
      //    Name = x.Name,
      //    Price = x.Price,
      //    Rating = x.Rating,
      //    Services = (x.Services ?? "").Split(",").ToList(),
      //    OtherImages = (x.OtherImages ?? "").Split(",").ToList(),
      //})
      //.ToList();


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
        public IActionResult ReadMore()
        {
            return View("Details");
        }

        [HttpPost]
        public IActionResult FeedBack(string message, int id)
        {

            var hotels = _context.Hotels.ToList();
            var compaines = _context.CompanyOffers.ToList();
            var tourgide = _context.Tourgides.ToList();



            var model = new HomeViewModel
            {
                Hotels = hotels,
                CompanyOffers = compaines,
                Tourgides = tourgide
            };
      

            var toursit = _context.Tourists.FirstOrDefault(x => x.Id == id);
            if (toursit == null)
            {
                ViewBag.error = "Tourist not found";
                return View("Index",model);
            }

            toursit.FeedBack = message;
            _context.SaveChanges();

            ViewBag.success = "Feedback sended successfully, we will contact you shortly!";
            return View("Index", model);
        }
    }
}
