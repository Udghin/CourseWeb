using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Domain.Entity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NoticeWithoutShit.Models.Account;

namespace NoticeWithoutShit.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<MyUser> _userManager;
        private readonly SignInManager<MyUser> _signInManager;

        public AccountController(
            UserManager<MyUser> userManager,
            SignInManager<MyUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userManager.CreateAsync(new MyUser
            {
                Email = "admin@admin.com"
            }, "adminadmin");
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                MyUser user = new MyUser { Email = model.Email, UserName = model.Email, FirstName = model.FirstName, LastName = model.LastName, PhoneNumber = model.PhoneNumber };
                // добавляем пользователя
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    // установка куки
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    // проверяем, принадлежит ли URL приложению
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else if (model.Email == "admin@admin.com" && model.Password == "adminadmin")
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Неправильный логин и (или) пароль");
                }
            }
            return View(model);
        }


        [Authorize]
        public async Task<IActionResult> EditUser(RegisterViewModel model)
        {
          

            if (ModelState.IsValid)
            {
              
                var u = await _userManager.FindByNameAsync(User.Identity.Name);
                u.Email = model.Email;
                u.FirstName = model.FirstName;
                u.LastName = model.LastName;
                u.Password = model.Password;
                u.PhoneNumber = model.PhoneNumber;
                // добавляем пользователя
                var result = await _userManager.UpdateAsync(u);
                if (result.Succeeded)
                {
                    // установка куки
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return View(model);
                }
            }


            return View(await GetUser());
        }

        public async Task<RegisterViewModel> GetUser()
        {
            var u = await _userManager.FindByNameAsync(User.Identity.Name);
            RegisterViewModel user = new RegisterViewModel();
            user.Email = u.Email;
            user.FirstName = u.FirstName;
            user.LastName = u.LastName;
            user.Password = u.Password;
            user.PasswordConfirm = u.Password;
            user.PhoneNumber = u.PhoneNumber;
            return user;
        }
    }
}
