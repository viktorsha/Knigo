using Knigo.Data.Interfaces;
using Knigo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knigo.Areas.Books.Controllers
{
    [Area("Books")]
    public class CategoryController : Controller
    {
        

        private readonly IBooksCategoryShakunVA _booksCategory;

        CategoryListViewModel category = new CategoryListViewModel();

        public CategoryController(IBooksCategoryShakunVA iCategory)
        {
            _booksCategory = iCategory;
        }
        [HttpGet]
        public ViewResult List()
        {
            try
            {
                category.allCategories = _booksCategory.GetCategories.ToList();
                return View(category);
            }
            catch
            {
                return View("NotFound");
            }
            
        }
    }
}
