using Microsoft.AspNetCore.Mvc;

namespace dlily_project.Controllers
{
    public class TourGuideController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TourGuideController(ApplicationDbContext context)
        {
            _context = context;
        }
     


        public IActionResult GuideProfile(string id)
        {
            var guide = _context.Tourgides.FirstOrDefault(g => g.Email == id);
            if (guide == null)
            {
                return NotFound(); 
            }

            return PartialView("_GuideProfile", guide);
        }

        [HttpGet]
        public IActionResult GetTourGuideEmails()
        {
            var tourGuideEmails = _context.Tourgides
                                          .Select(g => g.Email)
                                          .ToList();
            return Json(tourGuideEmails); 
        }
        public IActionResult GetImage(string email)
        {
            var guide = _context.Tourgides.FirstOrDefault(g => g.Email == email);
            if (guide == null || guide.ProfilePicture == null)
            {
                return NotFound();
            }

            return File(guide.ProfilePicture, "image/jpeg");
        }
    }
}
