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



        [HttpGet]
        public async Task<IActionResult> Register()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View(registerVM);
            }

            AppUser appUser = new AppUser
            {
                UserName = registerVM.UserName
            };

            IdentityResult identityResult = await _userManager.CreateAsync(appUser, registerVM.Password);

            if (!identityResult.Succeeded)
            {
                foreach (var item in identityResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(registerVM);
            }

            await _userManager.AddToRoleAsync(appUser, "Admin");

            //return RedirectToAction("Index", "Dashboard", new { area = "manage" });
            return RedirectToAction("Index");

        }

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

            ProfileVM profileVM = new ProfileVM
            {
                Name = appUser.Name,
                UserName = appUser.UserName,
                Email = appUser.Email
            };

            return View(profileVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]

        public async Task<IActionResult> Profile(ProfileVM profileVM)
        {
            if (!ModelState.IsValid)
            {
                return View(profileVM);
            }

            bool check = false;
            AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);

            if (appUser.Name.ToLowerInvariant() != profileVM.Name.Trim().ToLowerInvariant())
            {
                check = true;
                appUser.Name = profileVM.Name.Trim();
            }
            if (appUser.NormalizedEmail.ToLowerInvariant() != profileVM.Email.Trim().ToLowerInvariant())
            {
                check = true;
                appUser.Email = profileVM.Email.Trim();
            }
            
            if (appUser.NormalizedUserName.ToLowerInvariant() != profileVM.UserName.Trim().ToLowerInvariant())
            {
                check = true;
                appUser.UserName = profileVM.UserName.Trim();
            }

            if (check)
            {
               IdentityResult identityResult = await _userManager.UpdateAsync(appUser);

                if (!identityResult.Succeeded)
                {
                    foreach (var item in identityResult.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                    return View(profileVM);
                }
            }

            if (!string.IsNullOrWhiteSpace(profileVM.CurrentPassword))
            {
                if (!await _userManager.CheckPasswordAsync(appUser, profileVM.CurrentPassword))
                {
                    ModelState.AddModelError("CurrentPassword", "Email or password is incorrect");
                    return View(profileVM);
                }

                if (profileVM.CurrentPassword == profileVM.Password)
                {
                    ModelState.AddModelError("CurrentPassword", "The password you entered is not correct, please try again");
                    return View(profileVM);
                }

                string token = await _userManager.GeneratePasswordResetTokenAsync(appUser);

                IdentityResult identityResult = await _userManager.ResetPasswordAsync(appUser, token, profileVM.Password);
            
             };

            return RedirectToAction("Index", "Dashboard", new { area = "manage" });
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Login");

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
