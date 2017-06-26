using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practica2017.Models;

namespace Practica2017.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            /*var model = new LibraryViewModels();
            model.NumberOfBooks = 10;
            model.Date = DateTime.Now;
            return View(model);*/
            var list = new ListOfBookViewModel();
            list.ListOfBook = new List<Book>();
            for (int i=1;i<=5;i++)
            {
                var item = new Book();
                item.id = i;
                item.name = "name#" + i;
                item.author = "author#" + i;
                list.ListOfBook.Add(item);
            }
            return View(list);
        }
    }

}
