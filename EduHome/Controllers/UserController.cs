using EduHome.Models;
using EduHome.ViewModels.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class UserController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public UserController(RoleManager<IdentityRole> roleManager,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager
            )

        {

            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegVM regVM)
        {
            if (!ModelState.IsValid)
            {
                return View(regVM);
            }

            AppUser appUser = new AppUser
            {
                UserName = regVM.UserName,
                Email = regVM.Email
            };

            IdentityResult identityResult = await _userManager.CreateAsync(appUser, regVM.Password);

            if (!identityResult.Succeeded)
            {
                foreach (var item in identityResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(regVM);
            }

            await _userManager.AddToRoleAsync(appUser, "Member");

            return RedirectToAction("Index");

        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LogVM logVM)
        {
            if (!ModelState.IsValid)
            {
                return View(logVM);
            }

            AppUser appUser = await _userManager.FindByNameAsync(logVM.UserName);

            if (appUser == null)
            {
                ModelState.AddModelError("", "Username or Password is incorrect");
                return View(logVM);
            }

            Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.CheckPasswordSignInAsync(appUser, logVM.Password, true);

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Username or Password is incorrect");
                return View(logVM);
            }


            await _signInManager.PasswordSignInAsync(appUser, logVM.Password, logVM.RemindMe, true);


            return View("Index");

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
