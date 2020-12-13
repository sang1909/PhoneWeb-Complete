using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update;
using PhoneWeb.Models;

namespace PhoneWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    [Route("Admin/[controller]/[action]")]
    public class ManageUserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public ManageUserController(UserManager<User> _userManager, SignInManager<User> _signInManager)
        {
            this._userManager = _userManager;
            this._signInManager = _signInManager;
        }
        //-----------------------------------------------------------------------------------------
        public IActionResult ManagerUsers()
        {
            ListIdentityUser list = new ListIdentityUser()
            {
                ListUser = _userManager.Users.ToList()
            };
            return View(list);
        }

        //-----------------------------------------------------------------------------------------
        [HttpGet]
        public IActionResult Create(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Create(UserRegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.Email,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PhoneNumber = model.PhoneNumber,
                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    await _userManager.AddToRoleAsync(user, "Visitor");
                    return RedirectToAction("ManagerUsers", "ManageUser", new { Areas = "Admin" });
                }
            }
            return View(model);
        }
        //-----------------------------------------------------------------------------------------
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                ViewBag.ErrorMessenfe = "Xảy ra lỗi !!!!";
                return View();
            }
            //----------Roles
            var userClaims = await _userManager.GetClaimsAsync(user);
            var userRoles = await _userManager.GetRolesAsync(user);

            var modelUser = new EditUserModel
            {
                UserName = user.Email,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                //------------ Roles
                Claims = userClaims.Select(c => c.Value).ToList(),
                Roles = userRoles
            };
            return View(modelUser);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditUserModel model)
        {
            var user = await _userManager.FindByIdAsync(model.Id);
            if (user == null)
            {
                ViewBag.ErrorMessenfe = "Xảy ra lỗi !!!!";
                return View();
            }
            else
            {
                user.Email = model.UserName;
                user.Email = model.Email;
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.PhoneNumber = model.PhoneNumber;
                await _userManager.UpdateAsync(user);
                return RedirectToAction("ManagerUsers", "ManageUser", new { Areas = "Admin" });
            }
        }

        //-----------------------------------------------------------------------------------------
        public async Task<IActionResult> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                ViewBag.ErrorMessenfe = "Xảy ra lỗi !!!!";
                return View();
            }
            else
            {
                var results = _userManager.DeleteAsync(user);
                if (results.IsCompletedSuccessfully)
                {
                    return RedirectToAction("ManagerUsers", "ManageUser", new { Areas = "Admin" });
                }
            }
            return RedirectToAction("ManagerUsers", "ManageUser", new { Areas = "Admin" });
        }

  













    }
}
