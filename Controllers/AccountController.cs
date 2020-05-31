using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanyShop.Auth;
using BethanyShop.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BethanyShop.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public AccountController(SignInManager<ApplicationUser>signInManager,UserManager<ApplicationUser>userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
                
        }
        [HttpGet]
        [Route("Account/Login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if(!ModelState.IsValid)
            {
                return View(loginViewModel);
            }
            var user = await _userManager.FindByNameAsync(loginViewModel.UserName);
            if(user !=null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "user Name / Password not found");
            return View(loginViewModel);
        }
        [HttpGet]
        [Route("Account/Register")]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
             
                var user = new ApplicationUser()
                { UserName = loginViewModel.UserName };
                var result = await _userManager.CreateAsync(user, loginViewModel.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");

                }
            }
            return View(loginViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
           await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}