using Knigo.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knigo.ViewModels
{
    public class BooksListViewModelShakunVA : Controller
    {
        public IEnumerable<BookShakunVA> allBooks { get; set; }
        public int Count()
        {
            if (allBooks != null)
                return allBooks.Count();
            else
                return 1;
        }
        public BookShakunVA bookById { get; set; }
        public string currentCategory { get; set; }
        public IActionResult Index()
        {
            return View();
        }
    }
}
