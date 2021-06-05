using KitList.Business.Abstract;
using KitList.Entities.Concrete;
using KitList.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace KitList.WebUI.Controllers
{
    public class BookController : Controller
    {
        IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public ActionResult Index()
        {
            var books = _bookService.GetAll();
            BookListViewModel model = new BookListViewModel()
            {
                Books = books
            };
            return View(model);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookService.Add(book);
            }
            return RedirectToAction("Index");
        }


        public ActionResult Update(int id)
        {
            var model = new BookViewModel
            {
                book = _bookService.GetById(id)
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookService.Update(book);              
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            _bookService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}