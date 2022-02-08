using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Services.Abstractions.Dto.Notice;
using Services.Abstractions.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entity;
using Persistence;
using Services.AutoMapper;

namespace NoticeWithoutShit.Controllers
{
    public class UserController : Controller
    {
        IServiceManager _serviceManager;
        protected MyUserDbContext db;
        ObjectMapper mapper = ObjectMapper.Instance;
        public UserController(IServiceManager serviceManager,MyUserDbContext context)
        {
            _serviceManager = serviceManager;
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Dashboard()
        {
            //var userid = db.Users.FirstOrDefault(e => e.Email == User.Identity.Name).Id;
            var res = await _serviceManager.NoticesService.GetAllByNameAsync(User.Identity.Name);
            res.UserId= db.Users.FirstOrDefault(e => e.Email == User.Identity.Name).Id;
            return View(res);
        }
        public async Task<IActionResult> Archive()
        {
            var res = await _serviceManager.NoticesService.GetAllByNameAsync(User.Identity.Name);
            return View(res);
        }

        [HttpPost]
        public async Task<IActionResult> Archive(NoticeDto modelt)
        {
            var model = mapper.Mapper.Map<Notice>(modelt);
            //var res = await _serviceManager.NoticesService.GetAllByNameAsync(User.Identity.Name);
            if (modelt.Action == "finish")
            {
                var not = await _serviceManager.NoticesService.GetByIdAsync(model.Id);
                not.IsFinished = true;
                await _serviceManager.NoticesService.Update(not);
            }
            if (modelt.Action== "del")
            {
                var not = await _serviceManager.NoticesService.GetByIdAsync(model.Id);
                await _serviceManager.NoticesService.DeleteAsync(not.Id);
            }
            //if(model.Category != null && model.Name != null && model.Text != null)
            if (modelt.Action == "edit")
            {
                return RedirectToAction("EditNotice", new { id = model.Id });
            }
            var res = await _serviceManager.NoticesService.GetAllByNameAsync(User.Identity.Name);
            res.UserId = db.Users.FirstOrDefault(e => e.Email == User.Identity.Name).Id;
            return View(res);
        }


        public async Task<IActionResult> Search(string search)
        {
            var res = await _serviceManager.NoticesService.GetAllByNameAsync(User.Identity.Name);
            res.UserId = db.Users.FirstOrDefault(e => e.Email == User.Identity.Name).Id;
            res.Notices = res.Notices.FindAll(n => n.Text.Contains(search));
            res.Search = search;
            return View(res);
        }

        [HttpPost]
        public async Task<IActionResult> Search(NoticeDto modelt)
        {
            var res = await _serviceManager.NoticesService.GetAllByNameAsync(User.Identity.Name);
            res.UserId = db.Users.FirstOrDefault(e => e.Email == User.Identity.Name).Id;
            if (modelt.Search != null)
            {       
                res.Notices = res.Notices.FindAll(n => n.Text.Contains(modelt.Search)||n.Name.Contains(modelt.Search));
                res.Search = modelt.Search;
                if (modelt.Action.Length > 8)
                {
                    res.Sort = modelt.Action;
                }
                return View(res);
            }
            res.Notices.Clear();
            return View(res);
        }

        [HttpPost]
        public async Task<IActionResult> Dashboard(NoticeDto modelt)
        {
         if(modelt.Search!=null)
            {
                return RedirectToAction("Search", new { search = modelt.Search });
            }
            string errors = "";
            //var users = db.Users;
            //var userid = users.FirstOrDefault(e => e.Email == User.Identity.Name).Id;
            //var userid = db.Users.FirstOrDefault(e => e.Email == User.Identity.Name).Id;
            var res = await _serviceManager.NoticesService.GetAllByNameAsync(User.Identity.Name);
            var model = mapper.Mapper.Map<Notice>(modelt);
            if (model.Category != null && model.UserOwner != null && model.Name == null && model.Text == null)
            {
                var notices = await _serviceManager.NoticesService.GetAllAsync();
                foreach(var not in notices)
                {
                    if(model.Category==not.Category)
                        await _serviceManager.NoticesService.DeleteAsync(not.Id);
                }
                await _serviceManager.NoticesService.DeleteCategory(model.Id);
               

            }
            if (model.Category != null && model.UserOwner == null)
            {
                bool q = true;
                model.UserOwner = User.Identity.Name;
                foreach (var cat in res.Categories)
                {
                    if (cat.Name.ToLower() == model.Category.ToLower())
                    {
                        q = false;
                        errors = "\"" + cat.Name + "\"" + " уже существует!";
                    }
                }
                if (q) await _serviceManager.NoticesService.AddCategory(model);
            }
            if (modelt.Action == "finish")
            {
                var not = await _serviceManager.NoticesService.GetByIdAsync(model.Id);
                not.IsFinished = true;
                await _serviceManager.NoticesService.Update(not);
            }
            if (modelt.Action == "del")
            {
                var not = await _serviceManager.NoticesService.GetByIdAsync(model.Id);
                await _serviceManager.NoticesService.DeleteAsync(not.Id);
            }
            //if(model.Category != null && model.Name != null && model.Text != null)
            if (modelt.Action == "edit")
            {
                return RedirectToAction("EditNotice", new { id = model.Id });
            }
            res = await _serviceManager.NoticesService.GetAllByNameAsync(User.Identity.Name);
            res.UserId = db.Users.FirstOrDefault(e => e.Email == User.Identity.Name).Id;
            res.Errors = errors;

            if(modelt.Action.Length>8)
            {
                res.Sort = modelt.Action;
            }

          //  res.Notices = res.Notices.OrderBy(c => c.Category).ToList();
          //  res.Notices = res.Notices.OrderByDescending(c => c.Category).ToList();
            return View(res);
        }

        public async Task<IActionResult> ClearArchive()
        {
            var res = await _serviceManager.NoticesService.GetAllByNameAsync(User.Identity.Name);
            foreach(var not in res.Notices)
            {
                if(not.Deadline<DateTime.Now || not.IsFinished==true)
                {
                    await _serviceManager.NoticesService.DeleteAsync(not.Id);
                }
            }
           
            return RedirectToAction("Dashboard");
        }
        public async Task<IActionResult> AllToArchive()
        {
            var res = await _serviceManager.NoticesService.GetAllByNameAsync(User.Identity.Name);
            foreach (var not in res.Notices)
            {
                not.IsFinished = true;
                await _serviceManager.NoticesService.Update(not);
            }
            return RedirectToAction("Dashboard");
        }

        public async Task<IActionResult> EditNotice(Guid id)
        {
            var res = await _serviceManager.NoticesService.GetAllByNameAsync(User.Identity.Name);
            var not = res.Notices.FirstOrDefault(e => e.Id == id);
            NoticeAndCatsDto tmp = new NoticeAndCatsDto();
            tmp.Categories = res.Categories;
            tmp.Notices.Add(not);
            return View(tmp);
        }
        [HttpPost]
        public async Task<IActionResult> EditNotice(NoticeDto model)
        {
            model.UserOwner = User.Identity.Name;
            await _serviceManager.NoticesService.Update(model);
            return RedirectToAction("Dashboard");
        }

        public async Task<IActionResult> AddNotice()
        {
            var res = await _serviceManager.NoticesService.GetAllByNameAsync(User.Identity.Name);
            return View(res);
        }

        [HttpPost]
        public async Task<IActionResult> AddNotice(CreateNoticeDto model)
        {
            model.UserOwner = User.Identity.Name;
            model.Created = DateTime.Now;
            await _serviceManager.NoticesService.CreateAsync(model);
            return RedirectToAction("Dashboard");
        }
    }
}
