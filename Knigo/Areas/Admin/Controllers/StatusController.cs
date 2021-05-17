using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Knigo.Data;
using Knigo.Data.Models;

namespace Knigo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StatusController : Controller
    {
        private readonly AppDBContentShakunVA _context;

        public StatusController(AppDBContentShakunVA context)
        {
            _context = context;
        }

        // GET: Admin/Status
        public async Task<IActionResult> List()
        {
            return View(await _context.Status.ToListAsync());
        }

        // GET: Admin/Status/Details/5
        
        private bool StatusShakunVAExists(int id)
        {
            return _context.Status.Any(e => e.Id == id);
        }
    }
}
