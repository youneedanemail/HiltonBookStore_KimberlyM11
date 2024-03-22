
using HiltonBookStore_KimberlyM11.Models;
using HiltonBookStore_KimberlyM11.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HiltonBookStore_KimberlyM11.Controllers
{
    public class HomeController : Controller
    {
        private IBookStoreRepository _repo;

        public HomeController(IBookStoreRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            if (pageNum < 1)
            {
                pageNum = 1;
            }

            var bookView = new BookListViewModel
            {
                Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip(pageSize * (pageNum - 1))
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };
            return View(bookView);
        }

    }
}
