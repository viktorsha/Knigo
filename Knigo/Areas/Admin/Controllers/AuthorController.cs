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
    public class AuthorController : Controller
    {
        private readonly AppDBContentShakunVA _context;

        public AuthorController(AppDBContentShakunVA context)
        {
            _context = context;
        }

        // GET: Admin/Author
        public async Task<IActionResult> List()
        {
            return View(await _context.Author.ToListAsync());
        }

        // GET: Admin/Author/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authorShakunVA = await _context.Author
                .FirstOrDefaultAsync(m => m.Id == id);
            if (authorShakunVA == null)
            {
                return NotFound();
            }

            return View(authorShakunVA);
        }

        // GET: Admin/Author/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Author/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AuthorName,AmountOfWrittenBooks,AuthorInfo")] AuthorShakunVA authorShakunVA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(authorShakunVA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(List));
            }
            return View(authorShakunVA);
        }

        // GET: Admin/Author/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authorShakunVA = await _context.Author.FindAsync(id);
            if (authorShakunVA == null)
            {
                return NotFound();
            }
            return View(authorShakunVA);
        }

        // POST: Admin/Author/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AuthorName,AmountOfWrittenBooks,AuthorInfo")] AuthorShakunVA authorShakunVA)
        {
            if (id != authorShakunVA.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(authorShakunVA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AuthorShakunVAExists(authorShakunVA.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(List));
            }
            return View(authorShakunVA);
        }

        // GET: Admin/Author/Delete/5
        

        private bool AuthorShakunVAExists(int id)
        {
            return _context.Author.Any(e => e.Id == id);
        }
    }
}
