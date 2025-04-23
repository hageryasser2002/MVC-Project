﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_Projec2.Models;
using MVC_Projec2.ViewModels;
using System.Security.Claims;

namespace MVC_Projec2.Controllers
{
    public class AccountController : Controller


    {

        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(Register userFromREquest)
        {
            if (ModelState.IsValid)
            {
                
                ApplicationUser userApp = new ApplicationUser();
                userApp.FullName = userFromREquest.FullName;
                userApp.Email = userFromREquest.Email;
                userApp.PhoneNumber = userFromREquest.PhoneNumber;
                userApp.PasswordHash = userFromREquest.Password;
                userApp.PasswordHash = userFromREquest.ConfirmPassword;
                
                IdentityResult result = await userManager.CreateAsync(userApp, userFromREquest.Password);
                if (result.Succeeded)
                {
                  
                    await userManager.AddToRoleAsync(userApp, "User");
                    await signInManager.SignInAsync(userApp,isPersistent: false);
             
                    return RedirectToAction("Index", "Home");
                }
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View("Register", userFromREquest);
        }



        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(login userFRomREquest)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser appFromDb =
                    await userManager.FindByNameAsync(userFRomREquest.UserName);
                if (appFromDb != null)
                {
                    bool found = await userManager.CheckPasswordAsync(appFromDb, userFRomREquest.Password);
                    if (found)
                    {
                        List<Claim> claims = new List<Claim>();
                        claims.Add(new Claim("FullName", appFromDb.FullName));

                        await signInManager.SignInWithClaimsAsync(appFromDb, userFRomREquest.RememberMe, claims);
                      
                        return RedirectToAction("Index", "Home");
                    }
                }
                ModelState.AddModelError("", "Invalid Account");
            }
            return View("Login", userFRomREquest);
        }
    }
}
