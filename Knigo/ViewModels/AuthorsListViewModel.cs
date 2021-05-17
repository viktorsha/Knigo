using Knigo.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knigo.ViewModels
{
    public class AuthorListViewModel : Controller
    {
        public List<AuthorShakunVA> allAuthors { get; set; }
        public IEnumerable<SelectListItem> allAuthorsIE()
        {
            return (IEnumerable<SelectListItem>)allAuthors;   
        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
