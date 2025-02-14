using dlily_project.DAL.Models.Users;
using dlily_project.ViewModels.AuthViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace dlily_project.Controllers
{
    public class TouristController : Controller
    {
        private ApplicationDbContext _context;

        public TouristController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Profile()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Index", "Auth");
            }
            var tourist = await _context.Tourists.FirstOrDefaultAsync(x => x.Id == int.Parse(userId));
            if (tourist == null)
                return View();

            var touristModel = new TouristProfileViewModel
            {
                Name = tourist.Name,
                Email = tourist.Email,
                Address = tourist.Address,
                Gender = tourist.Gender,
                Phone = tourist.Phone,
                SpokenLanguage = tourist.SpokenLanguage,
                ShowProfilePicture = tourist.ProfilePicture,
            };

            return View(touristModel);
        }

        [Authorize]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Profile(TouristProfileViewModel model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value!;
            var user = (await _context.Tourists.FirstOrDefaultAsync(x => x.Id == int.Parse(userId)))!;
            if (!ModelState.IsValid)
            {
                model.ShowProfilePicture = model.ShowProfilePicture ?? user.ProfilePicture;
                return View(model);
            }
            try
            {


                if (model.NewProfilePicture != null)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await model.NewProfilePicture.CopyToAsync(memoryStream);
                        user.ProfilePicture = memoryStream.ToArray();
                    }
                }

                user.Name = model.Name;
                user.Email = model.Email;
                user.Phone = model.Phone;
                user.Address = model.Address;
                user.Gender = model.Gender;
                user.SpokenLanguage = model.SpokenLanguage;

                if (!string.IsNullOrEmpty(model.CurrentPassword) && !string.IsNullOrEmpty(model.NewPassword))
                {
                    if (user.Password == model.CurrentPassword)
                    {
                        user.Password = model.NewPassword;
                    }
                    ViewBag.error = "Your current password is incorrect, please try agian!";
                    model.ShowProfilePicture = model.ShowProfilePicture ?? user.ProfilePicture;
                    return View(model);
                }

                _context.Tourists.Update(user);
                await _context.SaveChangesAsync();

                ViewBag.success = "Login sucessfully!";

                model.ShowProfilePicture = model.ShowProfilePicture ?? user.ProfilePicture;
                return View(model);
            }
            catch (Exception ex)
            {
                ViewBag.error = "An error occurred while processing your request. Please try again.";
                model.ShowProfilePicture = model.ShowProfilePicture ?? user.ProfilePicture;
                return View(model);
            }

        }
    }
}
