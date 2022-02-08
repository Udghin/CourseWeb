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

    //    // GET: AdminController
    //    [Authorize]
    //    public async Task<IActionResult> IndexBooks()
    //    {
    //        List<StoreBookDto> books = (await _serviceManager.StoreBooksService.GetAllAsync()).ToList();
    //        return View(new HomeIndexBookViewModel
    //        {
    //            Books = books
    //        });
    //    }

    //    [Authorize]
    //    public async Task<IActionResult> IndexOrders()
    //    {
    //        List<OrderDto> orders = (await _serviceManager.OrdersService.GetAllAsync()).ToList();
    //        return View(new HomeIndexOrderViewModel
    //        {
    //            Orders = orders
    //        });
    //    }

    //    // GET: AdminController/Details/5
    //    [Authorize]
    //    public async Task<IActionResult> DetailsBook(Guid id)
    //    {
    //        var book = await _serviceManager.StoreBooksService.GetByIdAsync(id);
    //        if (book is null)
    //        {
    //            return BadRequest("Book wasn`t found!");
    //        }
    //        return View(book);
    //    }

    //    public async Task<IActionResult> DetailsOrder(Guid id)
    //    {
    //        var order = await _serviceManager.OrdersService.GetByIdAsync(id);
    //        if (order is null)
    //        {
    //            return BadRequest("Order wasn`t found!");
    //        }
    //        return View(order);
    //    }

    //    // GET: AdminController/Create
    //    [Authorize]
    //    public IActionResult Create()
    //    {
    //        return View();
    //    }

    //    // POST: AdminController/Create
    //    [HttpPost]
    //    [Authorize]
    //    public async Task<IActionResult> Create(CreateNoticeDto model)
    //    {
    //        await _serviceManager.StoreBooksService.CreateAsync(new CreateNoticeDto
    //        {
    //            Authors = model.Authors,
    //            Cost = model.Cost,
    //            Count = model.Count,
    //            CountPages = model.CountPages,
    //            Genre = model.Genre,
    //            Name = model.Name,
    //            PublishOffice = model.PublishOffice,
    //            PublishYear = model.PublishYear
    //        });
    //        return RedirectToAction("Index");
    //    }

    //    // GET: AdminController/Edit/5
    //    [Authorize]
    //    public async Task<IActionResult> EditBook(Guid id)
    //    {
    //        var book = await _serviceManager.StoreBooksService.GetByIdAsync(id);
    //        if (book != null)
    //        {
    //            return View(book);
    //        }
    //        else
    //        {
    //            return NotFound("Book wasn`t found!");
    //        }
    //    }

    //    // POST: AdminController/Edit/5
    //    [HttpPost]
    //    [Authorize]
    //    public async Task<IActionResult> EditBook(StoreBookDto model)
    //    {
    //        var books = _sessionService.GetCartProducts(HttpContext, "cart");
    //        if (books!=null)
    //        {
    //            foreach (var item in books)
    //            {
    //                if (item.Id == model.Id)
    //                {
    //                    await _serviceManager.StoreBooksService.Update(item.Book);
    //                }
    //            }
    //        }
    //        await _serviceManager.StoreBooksService.Update(model);
    //        return RedirectToAction("Index");
    //    }

    //    [Authorize]
    //    public async Task<IActionResult> EditOrder(Guid id)
    //    {
    //        var order = await _serviceManager.OrdersService.GetByIdAsync(id);
    //        if (order != null)
    //        {
    //            return View(order);
    //        }
    //        else
    //        {
    //            return NotFound("Order wasn`t found!");
    //        }
    //    }

    //    // POST: AdminController/Edit/5
    //    [HttpPost]
    //    [Authorize]
    //    public async Task<IActionResult> EditOrder(OrderDto model)
    //    {
    //        await _serviceManager.OrdersService.Update(model);
    //        return RedirectToAction("Index");
    //    }

    //    // POST: AdminController/Delete/5
    //    [HttpPost]
    //    [Authorize]
    //    public async Task<IActionResult> DeleteBook(Guid id)
    //    {
    //        var books = _sessionService.GetCartProducts(HttpContext, "cart");
    //        foreach (var item in books)
    //        {
    //            if (item.Id == id)
    //            {
    //                _sessionService.RemoveProductFromCart(HttpContext, "cart", item);
    //            }
    //        }
    //        await _serviceManager.StoreBooksService.DeleteAsync(id);
    //        return RedirectToAction("Index");
    //    }

    //    [HttpPost]
    //    [Authorize]
    //    public async Task<IActionResult> DeleteOrder(Guid id)
    //    {
    //        //var order = await _serviceManager.OrdersService.GetByIdAsync(id);
    //        //foreach (var item in order.BooksId)
    //        //{
    //        //    var book = _serviceManager.StoreBooksService.GetByIdAsync(item.Id);
    //        //    //item.Count += (int)order.Price / (int)item.Cost;
    //        //    await _serviceManager.StoreBooksService.Update(item);
    //        //}
    //        await _serviceManager.OrdersService.DeleteAsync(id);
    //        return RedirectToAction("Index");
    //    }
    }
}
