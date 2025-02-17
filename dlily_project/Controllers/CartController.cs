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
            if (selectedGuide == null)
            {
                return NotFound();
            }

          
            cart.Add(new CartItem
            {
                Id = selectedGuide.Id,
                Name = selectedGuide.Name,
                Price = selectedGuide.Price
            });

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
