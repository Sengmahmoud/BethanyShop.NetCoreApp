using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanyShop.Auth;
using BethanyShop.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BethanyShop.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AdminController(UserManager<ApplicationUser>userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("Admin/UserManagement")]
        public IActionResult UserManagement()
        {
            var users = _userManager.Users;
            return View(users);
        }
        [HttpGet]
        [Route("Admin/AddUser")]
        public IActionResult AddUser()
        {
            return View();
        
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserViewModel addUserViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(addUserViewModel);
            }
            var user = new ApplicationUser()
            {
                UserName = addUserViewModel.UserName,
                Email = addUserViewModel.Email,
                Birthdate=addUserViewModel.Birthdate,
                City=addUserViewModel.City,
                Country=addUserViewModel.Country
                
            };
            IdentityResult result = await _userManager.CreateAsync(user, addUserViewModel.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("UserManagement", _userManager.Users);

            }
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
                

            }
            return View(addUserViewModel);

        }
        [HttpGet]
        [Route("Admin/EditUser/{id}")]
        public async Task<IActionResult> EditUser(string id)
        {

            var user = await _userManager.FindByIdAsync(id);
            if (user ==null)
            {
                return RedirectToAction("UserManagement", _userManager.Users);
            }
            return View(user);

        }
        [HttpPost]
        public async Task<IActionResult> EditUser(string id, string username , string email,
            DateTime birthdate,string city, string country)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                user.Email = email;
                user.UserName = username;
                user.Birthdate = birthdate;
                user.City =city;
                user.Country = country;
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("UserManagement", _userManager.Users);
                }
                ModelState.AddModelError("", "Not Updated Somthing Error");
                return View(user);
            }

            return RedirectToAction("UserManagement", _userManager.Users);
        }
        public async Task<IActionResult> DeleteUserAsync(string userid)
        {
            var user = await _userManager.FindByIdAsync(userid);
            if (user != null)
            {
               
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("UserManagement", _userManager.Users);
                }
               else
                    ModelState.AddModelError("", "Not Updated Somthing Error");
              
            }
            else
            {
                ModelState.AddModelError("", "User Not Founded");
            }
            return RedirectToAction("UserManagement");
        }
    }
}