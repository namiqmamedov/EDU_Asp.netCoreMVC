using EduHome.Areas.Manage.ViewModels.Account;
using EduHome.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Manage.Controllers
{
    [Area("manage")]
    public class AccountController : Controller
    {


        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public AccountController(RoleManager<IdentityRole> roleManager,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager
            )

        {

            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        //[HttpGet]
        //public async Task<IActionResult> Register()
        //{
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Register(RegisterVM registerVM)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(registerVM);
        //    }

        //    AppUser appUser = new AppUser
        //    {
        //        Name = registerVM.Name,
        //        Email = registerVM.Email,
        //        UserName = registerVM.UserName
        //    };

        //    IdentityResult identityResult = await _userManager.CreateAsync(appUser, registerVM.Password);

        //    if (!identityResult.Succeeded)
        //    {
        //        foreach (var item in identityResult.Errors)
        //        {
        //            ModelState.AddModelError("", item.Description);
        //        }
        //        return View(registerVM);
        //    }

        //    return RedirectToAction("Index", "Dashboard", new { area = "manage" });
        //    //return RedirectToAction("login");

        //}

        [HttpGet]

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }

            AppUser appUser = await _userManager.FindByNameAsync(loginVM.UserName);

            if (appUser == null)
            {
                ModelState.AddModelError("", "Username or Password is incorrect");
                return View(loginVM);
            }

            Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.CheckPasswordSignInAsync(appUser, loginVM.Password, true);

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Username or Password is incorrect");
                return View(loginVM);
            }


            await _signInManager.PasswordSignInAsync(appUser, loginVM.Password, loginVM.RemindMe, true);


            return RedirectToAction("Index", "Dashboard", new { area = "manage" });

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize]

        public async Task<IActionResult> Profile()
        {
            AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);

            //ProfileVM profileVM = new ProfileVM
            //{
            //    Name = appUser.Name,
            //    UserName = appUser.UserName,
            //    Email = appUser.Email
            //};

            return View(/*profileVM*/);
        }



        //public async Task<IActionResult> CreateSuperAdmin()
        //{
        //    AppUser appUser = new AppUser
        //    {
        //        Email = "superadmin@protonmail.com",
        //        Name = "admin",
        //        UserName = "superadmin"
        //    };


        //    await _userManager.CreateAsync(appUser, "Admin1234");
        //    await _userManager.AddToRoleAsync(appUser, "SuperAdmin");

        //    return Ok();
        //}

        //public async Task<IActionResult> CreateRole()
        //{
        //    await _roleManager.CreateAsync(new IdentityRole { Name = "SuperAdmin" });
        //    await _roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
        //    await _roleManager.CreateAsync(new IdentityRole { Name = "Member" });

        //    return Ok();
        //}
    }
}
