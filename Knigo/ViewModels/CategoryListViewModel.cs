using Knigo.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knigo.ViewModels
{
    public class CategoryListViewModel : Controller
    {
        public List<Category> allCategories { get; set; }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
