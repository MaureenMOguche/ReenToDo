using Microsoft.AspNetCore.Mvc;
using ReenToDo.DataAccess;
using ReenToDo.Models;

namespace ReenToDo.Controllers
{
    public class ToDoController : Controller
    {
        private readonly TodoDbContext _db;
        public ToDoController(TodoDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<ToDoModel> ListOfItems = _db.ToDoList;
            return View(ListOfItems);
        }

        [HttpGet]
        public IActionResult AddToDo()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddToDo(ToDoModel item)
        {
            if (ModelState.IsValid)
            {
                _db.ToDoList.Add(item);
                _db.SaveChanges();
                
                ModelState.Clear();
                return View();
            }
            return View();
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editItem = _db.ToDoList.Find(id);

            if (editItem == null)
            {
                return NotFound();
            }

            return View(editItem);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ToDoModel item)
        {
            if (ModelState.IsValid)
            {
                _db.ToDoList.Update(item);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Remove(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editItem = _db.ToDoList.Find(id);

            if (editItem == null)
            {
                return NotFound();
            }

            return View(editItem);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Remove(ToDoModel item)
        {
            _db.ToDoList.Remove(item);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}