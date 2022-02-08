using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using Services.Abstractions.Dto.Notice;
using Services.Abstractions.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api_withoutshit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticesController : ControllerBase
    {
        IServiceManager _serviceManager;
        protected MyUserDbContext db;
        public NoticesController(IServiceManager serviceManager, MyUserDbContext context)
        {
            _serviceManager = serviceManager;
            db = context;
        }
        // GET: api/<NoticesController>
        [HttpGet]
        public async Task<NoticeAndCatsDto> GetAllByUserId(string id)
        {

            var users = db.Users;
            string username = "";
            foreach (var user in users)
            {
                if (user.Id == id)
                {
                    username = user.UserName;
                }
            }
            var res = await _serviceManager.NoticesService.GetAllByNameAsync(username);
            return res;
        }

        // GET api/<NoticesController>/5
        [HttpGet("{id}")]
        public async Task<NoticeDto> GetNotice(string id)
        {
            return await _serviceManager.NoticesService.GetByIdAsync(new Guid(id));
        }

        // POST api/<NoticesController>
        [HttpPost]
        public async Task<string> AddNotice([FromBody] CreateApiNoticeDto value)
        {
            //Category 5a4aa7fc-436d-4fac-105d-08d9cca13855
            //User 60f139e7-0bb2-4e4c-979d-20fedb2c2ddc
            var users = db.Users;
            bool isUser = false;
            bool isCategory = false;
            string username = "";
            string category = "";
            foreach (var user in users)
            {
                if (user.Id == value.UserId)
                {
                    isUser = true;
                    username = user.UserName;
                }
            }
            if (isUser == false) return "Пользователь не найден. Заметка не добавлена!";
            var res = await _serviceManager.NoticesService.GetAllByNameAsync(username);
            CreateNoticeDto newNotice = new CreateNoticeDto();
            foreach (var cat in res.Categories)
            {
                if (cat.Id.ToString() == value.CategoryId)
                {
                    isCategory = true;
                    category = cat.Name;
                }
            }
            if (isCategory == false)
            {          
                newNotice.Name = value.Name;
                newNotice.Text = value.Text;
                newNotice.Color = value.Color;
                newNotice.IsPublic = value.IsPublic;
                newNotice.Deadline = value.Deadline;
                newNotice.UserOwner = username;
                newNotice.Category = "<БЕЗ КАТЕГОРИИ>";
                return "Заметка успешно добавлена! В категорию - <БЕЗ КАТЕГОРИИ>";
            }
            if (isCategory == true)
            {
                newNotice.Name = value.Name;
                newNotice.Text = value.Text;
                newNotice.Color = value.Color;
                newNotice.IsPublic = value.IsPublic;
                newNotice.Deadline = value.Deadline;
                newNotice.UserOwner = username;
                newNotice.Category = category;
            }
            await _serviceManager.NoticesService.CreateAsync(newNotice);
            return "Заметка успешно добавлена!";
        }

        // PUT api/<NoticesController>/5
        [HttpPut("{id}")]
        public async Task<string> UpdateNotice(string id, [FromBody] CreateApiNoticeDto value)
        {
            var not = await _serviceManager.NoticesService.GetByIdAsync(new Guid(id));
            not.Name = value.Name;
            not.Text = value.Text;
            if(value.Color!="string" || value.Color!="")
            not.Color = value.Color;
            not.IsPublic = value.IsPublic;
            not.Deadline = value.Deadline;
            await _serviceManager.NoticesService.Update(not);
            return "Заметка успешно обновлена!";
        }

        // DELETE api/<NoticesController>/5
        [HttpDelete("{id}")]
        public async Task<string> DeleteNotice(string id)
        {
            // a35b8cac-3653-466e-715e-08d9cee02340
            var not = await _serviceManager.NoticesService.GetByIdAsync(new Guid(id));

            await _serviceManager.NoticesService.DeleteAsync(not.Id);
            return "Заметка успешно удалена";
        }
    }
}
