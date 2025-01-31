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
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TouristSignIn()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TouristSignIn(TouristSignInViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = _context.Tourists.FirstOrDefault(x=>x.Email ==  model.Email && x.Password == model.Password);
            if (user == null)
            {
                ViewBag.error = "Incorrect email or password, please try agian";
                return View(model);
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Role, "Tourist"),
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authProperties = new AuthenticationProperties();

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties
            );

            ViewBag.success = "Login sucessfully!";

            return View(model); 
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
                var existTourist = await _context.Tourists.FirstOrDefaultAsync(x => x.Email == model.Email);
                if (existTourist != null)
                {
                    ViewBag.EmailExists = "This email is already registered!";
                    return View(model);
                }
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
                        await model.ProfilePicture.CopyToAsync(memoryStream);
                        tourist.ProfilePicture = memoryStream.ToArray();
                    }
                }

                await _context.Tourists.AddAsync(tourist);
                await _context.SaveChangesAsync();

                ViewBag.SuccessMessage = "Your account has been created successfully!";
                return View(model);
            }
            catch (Exception ex)
            {
                ViewBag.error = "An error occurred while processing your request. Please try again.";
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

            var existTourist = await _context.Tourgides.FirstOrDefaultAsync(x => x.Email == model.Email);
            if (existTourist != null)
            {
                ViewBag.EmailExists = "This email is already registered!";
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
                        await model.ProfilePicture.CopyToAsync(memoryStream);
                        tourgide.ProfilePicture = memoryStream.ToArray();
                    }
                }

                await _context.Tourgides.AddAsync(tourgide);
                await _context.SaveChangesAsync();
                ViewBag.SuccessMessage = "Your account has been created successfully!";
                return View(model);
            }
            catch (Exception ex)
            {
                ViewBag.error = "An error occurred while processing your request. Please try again.";
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult TourgideSignIn()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TourgideSignIn(TourgideSignInViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _context.Tourgides.FirstOrDefaultAsync(x => x.Email == model.Email && x.Password == model.Password);
            if (user == null)
            {
                ViewBag.error = "Incorrect email or password, please try agian";
                return View(model);
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Role, "Tourgide"),
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authProperties = new AuthenticationProperties();

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties
            );

            ViewBag.success = "Login sucessfully!";
            return View(model);
        }
    }
}
