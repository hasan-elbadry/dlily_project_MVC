using dlily_project.DAL;
using dlily_project.DAL.Enum;
using dlily_project.DAL.Models.Users;
using dlily_project.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Scripting;

namespace dlily_project.Controllers
{
    public class AuthController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuthController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult TouristSignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> TouristSignIn(TouristSignInViewModel model)
        {
            return View();
        }

        [HttpGet]
        public IActionResult TouristSignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TouristSignUp(TouristSignUpViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            
            try
            {
                var tourist = new Tourist
                {
                    Name = model.Name,
                    Email = model.Email,
                    Phone = model.Phone,
                    Address = model.Address,
                    Gender = (Gender)model.Gender,
                    Password = model.Password,
                };


                if (model.ProfilePicture != null)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        model.ProfilePicture.CopyTo(memoryStream);
                        tourist.ProfilePicture = memoryStream.ToArray();
                    }
                }

                _context.Tourists.Add(tourist);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Sign-up successful! You can now log in.";
                return RedirectToAction("Index","Home");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An error occurred while processing your request.");
                return View(model);
            }
        }


        [HttpGet]
        public IActionResult TourgideSignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TourgideSignUp(TourgideSignUpViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                var tourgide = new Tourgide
                {
                    Name = model.Name,
                    Email = model.Email,
                    Phone = model.Phone,
                    Address = model.Address,
                    Gender = (Gender)model.Gender,
                    Password = model.Password,
                    Description = model.Description,
                     SpokenLanguage = model.SpokenLanguage,
                };


                if (model.ProfilePicture != null)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        model.ProfilePicture.CopyTo(memoryStream);
                        tourgide.ProfilePicture = memoryStream.ToArray();
                    }
                }

                _context.Tourgides.Add(tourgide);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Sign-up successful! You can now log in.";
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An error occurred while processing your request.");
                return View(model);
            }
        }
        [HttpGet]
        public IActionResult TourgideSignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> TourgideSignIn(TourgideSignInViewModel model)
        {
            return View();
        }
    
    }
}
