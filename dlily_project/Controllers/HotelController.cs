using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace dlily_project.Controllers
{
    public class HotelController : Controller
    {

        private readonly ApplicationDbContext _context;

        private readonly HttpClient _httpClient;

        public HotelController(ApplicationDbContext context, HttpClient httpClient)
        {
            _context = context;
            _httpClient = httpClient;
        }

        private string HotelJson;
        private string RoomJson;


        [Authorize]
        public async Task<IActionResult> Hotels()
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

            HotelJson = hotelJson;

            var hotelDetails = Newtonsoft.Json.JsonConvert.DeserializeObject<HotelViewModel>(hotelJson);
            return View(hotelDetails);
        }

        [Authorize]
        [HttpGet]
        public IActionResult HotelDetails()
        {
            if (string.IsNullOrEmpty(HotelJson))
            {
                return RedirectToAction("Hotels");
            }

            var hotelDetails = Newtonsoft.Json.JsonConvert.DeserializeObject<HotelViewModel>(HotelJson);
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
            RoomJson = roomData;
            var hotelDetails = Newtonsoft.Json.JsonConvert.DeserializeObject<RoomViewModel>(roomData);
            return View(hotelDetails);
        }

        [Authorize]
        [HttpGet]
        public IActionResult RoomDetails()
        {
            if (string.IsNullOrEmpty(RoomJson))
            {
                return RedirectToAction("Hotels");
            }

            var hotelDetails = Newtonsoft.Json.JsonConvert.DeserializeObject<RoomViewModel>(RoomJson);
            return View(hotelDetails);
        }
    }
}
