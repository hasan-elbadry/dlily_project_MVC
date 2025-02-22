using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dlily_project.Controllers
{
    public class CartController : Controller
    {
        private static List<CartItem> cart = new List<CartItem>();
         private readonly ApplicationDbContext _context;

    public CartController(ApplicationDbContext context)
    {
        _context = context;
    }

        [HttpGet]
        public JsonResult GetCart()
        {
            return Json(cart); 
        }
        public IActionResult AddToCart(int id)
        {
            var selectedGuide = _context.Tourgides.FirstOrDefault(g => g.Id == id);
            var selectedRoom = _context.Hotels
                .SelectMany(h => h.Rooms) // Flatten all rooms across hotels
                .FirstOrDefault(room => room.Id == id); // Assuming rooms have a unique ID

            if (selectedGuide == null && selectedRoom == null)
            {
                return NotFound();
            }

            if (selectedGuide != null)
            {
                cart.Add(new CartItem
                {
                    Id = selectedGuide.Id,
                    Image = selectedGuide.ProfilePicture != null
    ? "data:image/png;base64," + Convert.ToBase64String(selectedGuide.ProfilePicture)
    : null,
                    Name = selectedGuide.Name,
                    Price = selectedGuide.Price
                });
            }
            else if (selectedRoom != null)
            {
                cart.Add(new CartItem
                {
                    Id = selectedRoom.Id,
                    Image = selectedRoom.Images,
                    Name = $"Room {selectedRoom.RoomNumber}",
                    Price = selectedRoom.Price // Assuming rooms have a price
                });
            }

            return RedirectToAction("Cart");
        }


        public IActionResult Cart()
        {
            return View(cart); 
        }
        
     
        public IActionResult Checkout()
        {
            double totalAmount = cart.Sum(item => item.Price);
          
            return View(totalAmount);
        }
    }

}
