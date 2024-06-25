using BookProject.Web.DataAccess;
using BookProject.Web.Models;

using Microsoft.AspNetCore.Mvc;


namespace BookProject.Web.Controllers
{
    public class BookController : Controller
    {

        private readonly BookDbContext _db;

        public BookController(BookDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {

            List<Book> bookList = _db.Books.ToList();

            return View(bookList);
        }



        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
		public IActionResult Create(Book book)
		{
            if(ModelState.IsValid)
            {
                _db.Books.Add(book);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
		}



		public IActionResult Edit(int? id)
		{
            if(id == null)
            {
                return NotFound();
            }

            Book book_db = _db.Books.Find(id);
                // OR
                //var book_db2 = _db.Books.FirstOrDefault(b => b.Id == id);


			return View(book_db);
		}


		[HttpPost]
		public IActionResult Edit(Book book)
		{
			if (ModelState.IsValid)
			{
				_db.Books.Update(book);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View();
		}






	}
}
