//using Domain.Entity;
using Domain.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Services.Abstractions.Service;
using Services.AutoMapper.Profiles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using NoticeWithoutShit.Models;

using Microsoft.AspNetCore.Hosting;

namespace NoticeWithoutShit.Controllers
{
    public class HomeController : Controller
    {
        IServiceManager _serviceManager;
        IWebHostEnvironment _env;
        UserManager<MyUser> _userManager;

        public HomeController(IServiceManager serviceManager, UserManager<MyUser> userManager, IWebHostEnvironment env)
        {
            _serviceManager = serviceManager;
            _userManager = userManager;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            var notices = await _serviceManager.NoticesService.GetAllPublicAsync();
            return View(notices);
        }

        [HttpPost]
        public  IActionResult Index(string id)
        {
            return RedirectToAction("NoticeDetail", new {id=id });
        }

        public async Task<IActionResult> NoticeDetail(string id)
        {
            var notice = await _serviceManager.NoticesService.GetByIdAsync(new Guid(id));
            return View(notice);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
