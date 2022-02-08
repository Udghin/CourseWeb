using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoticeWithoutShit.Models.Admin;


namespace NoticeWithoutShit.Controllers
{
    public class AdminController : Controller
    {
        IServiceManager _serviceManager;
        public AdminController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
