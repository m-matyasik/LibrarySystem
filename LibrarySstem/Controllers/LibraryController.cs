using LibrarySystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.Controllers
{
    public class LibraryController : Controller
    {
        private static List<Book> Books = new List<Book>
         {
                 new Book(){Id = 1, Title = "To Kill a Mockingbird", Description = "Compassionate, dramatic, and deeply moving, \"To Kill A Mockingbird\" takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos.", Author="Harper Lee", Rating = 4.26},
                 new Book(){Id = 2, Title = "1984", Description = "1984 is still the great modern classic of \"negative utopia\".", Author="George Orwell", Rating = 4.19},
                 new Book(){Id = 3, Title = "The Lord of the Rings", Description = "Book about team who went to Mountain of Destiny to destroy Ring of Power.", Author="J.R.R. Tolkien", Rating = 4.52},
                 new Book(){Id = 4, Title = "The Catcher in the Rye", Description = "The Catcher in the Rye is an all-time classic in coming-of-age literature- an elegy to teenage alienation, capturing the deeply human need for connection and the bewildering sense of loss as we leave childhood behind.\r\n", Author="J.D. Salinger", Rating = 3.80},
                 new Book(){Id = 5, Title = "The Great Gatsby", Description = "This exemplary novel of the Jazz Age has been acclaimed by generations of readers.", Author="F. Scott Fitzgerald", Rating = 3.93},
                 new Book(){Id = 6, Title = "The Lion, the Witch and the Wardrobe (Chronicles of Narnia, #1)", Description = "Narnia… the land beyond the wardrobe door, a secret place frozen in eternal winter, a magical country waiting to be set free.", Author="C.S. Lewis", Rating = 4.23},
                 new Book(){Id = 7, Title = "Lord of the Flies", Description = "At the dawn of the next world war, a plane crashes on an uncharted island, stranding a group of schoolboys.", Author="William Golding", Rating = 3.69},
                 new Book(){Id = 8, Title = "Animal Farm", Description = "\"All animals are equal, but some animals are more equal than others.\"", Author="George Orwell", Rating = 3.98},
                 new Book(){Id = 9, Title = "Catch-22", Description = "Fifty years after its original publication, Catch-22 remains a cornerstone of American literature and one of the funniest—and most celebrated—books of all time.", Author="Joseph Heller", Rating = 3.99},
                 new Book(){Id = 10, Title = "The Grapes of Wrath", Description = "The Grapes of Wrath is a landmark of American literature.", Author="John Steinbeck", Rating = 4.00},
         };


        // GET: LibraryController
        public ActionResult Index()
        {
            return View(Books);
        }

        // GET: LibraryController/Details/5
        public ActionResult Details(int id)
        {
            return View(Books.FirstOrDefault(x => x.Id == id));
        }

        // GET: LibraryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LibraryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book book)
        {
            book.Id = Books.Count + 1;
            Books.Add(book);
            return RedirectToAction("Index");
        }

        // GET: LibraryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Books.FirstOrDefault(x => x.Id == id));
        }

        // POST: LibraryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Book book)
        {
            Book bookEdited = Books.FirstOrDefault(x => x.Id == id);
            bookEdited.Title = book.Title;
            bookEdited.Description = book.Description;
            bookEdited.Author = book.Author;
            bookEdited.Rating = book.Rating;
            
            return RedirectToAction("Index");
        }

        // GET: LibraryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Books.FirstOrDefault(x => x.Id == id));
        }

        // POST: LibraryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Book book)
        {
            Book toDelete = Books.FirstOrDefault(x => x.Id==id);
            Books.Remove(toDelete);

            return RedirectToAction("Index");
        }
    }
}
