using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Lumiere.Models.Tables;
using Lumiere.Models.ViewModels;

namespace Lumiere.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<UserTable> userManager;
        private SignInManager<UserTable> signInManager;
        public AccountController(UserManager<UserTable> userManager, SignInManager<UserTable> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new UserTable { FirstName = registerViewModel.FirstName, LastName = registerViewModel.LastName, UserName = registerViewModel.UserName, Email = registerViewModel.Email};
                IdentityResult result = await userManager.CreateAsync(user, registerViewModel.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index", "home");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(registerViewModel);
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginView)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(loginView.Email);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, loginView.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("index", "home");
                    }
                    ModelState.AddModelError(nameof(LoginViewModel.Email), "Invalid user or password");
                }
            }
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }
    }
}