using dlily_project.DAL.Models.Offers;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Text.Json;

namespace dlily_project.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;

        private readonly HttpClient _httpClient;

        public HomeController(ApplicationDbContext context, HttpClient httpClient)
        {
            _context = context;
            _httpClient = httpClient;
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



            var model = new HomeViewModel
            {
                Hotels = hotels,
                CompanyOffers  = compaines,
                Tourgides = tourgide
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
        public async Task<IActionResult>  Hotels()
        {
            var hotels = await _httpClient.GetFromJsonAsync<List<HotelViewModel>>("http://hotelsdlily.runasp.net/api/hotel");
            return View(hotels);
        }


        [Authorize]
        [HttpPost]
        public IActionResult HotelDetails(string hotelJson)
        {
            if (string.IsNullOrEmpty(hotelJson))
            {
                return RedirectToAction("Hotels");
            }

            var hotelDetails = Newtonsoft.Json.JsonConvert.DeserializeObject<HotelViewModel>(hotelJson);
            return View(hotelDetails);
        }

        [Authorize]
        [HttpPost]
        public IActionResult RoomDetails(string roomData)
        {
            if (string.IsNullOrEmpty(roomData))
            {
                return RedirectToAction("Hotels");
            }

            var hotelDetails = Newtonsoft.Json.JsonConvert.DeserializeObject<RoomViewModel>(roomData);
            return View(hotelDetails);
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
