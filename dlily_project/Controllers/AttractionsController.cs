using dlily_project.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace dlily_project.Controllers
{
    public class AttractionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AttractionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var attractions = _context.TouristPlaces.ToList();
            return View(attractions);
        }

        public IActionResult Detail(int id)
        {
            var place = _context.TouristPlaces.FirstOrDefault(p => p.Id == id);
            if (place == null)
            {
                return NotFound();
            }
            return View(place);
        }
    }
}
