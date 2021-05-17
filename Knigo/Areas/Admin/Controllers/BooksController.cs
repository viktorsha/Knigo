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
    public class BooksController : Controller
    {
        private readonly AppDBContentShakunVA _context;

        public BooksController(AppDBContentShakunVA context)
        {
            _context = context;
        }

        // GET: Admin/Books
        public async Task<IActionResult> List()
        {
            var appDBContentShakunVA = _context.Book.Include(b => b.Author).Include(b => b.Category).Include(b => b.Publisher).Include(b => b.Rank).Include(b => b.Status);
            return View(await appDBContentShakunVA.ToListAsync());
        }

        // GET: Admin/Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookShakunVA = await _context.Book
                .Include(b => b.Author)
                .Include(b => b.Category)
                .Include(b => b.Publisher)
                .Include(b => b.Rank)
                .Include(b => b.Status)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookShakunVA == null)
            {
                return NotFound();
            }

            return View(bookShakunVA);
        }

        // GET: Admin/Books/Create
        public IActionResult Create()
        {
            ViewData["AuthorId"] = new SelectList(_context.Author, "Id", "Id");
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Id");
            ViewData["PublisherId"] = new SelectList(_context.Publisher, "Id", "Id");
            ViewData["RankId"] = new SelectList(_context.Rank, "Id", "Id");
            ViewData["StatusId"] = new SelectList(_context.Status, "Id", "Id");
            return View();
        }

        // POST: Admin/Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,AuthorId,PublisherId,Year,Price,StatusId,Annotation,CategoryId,Img,RankId")] BookShakunVA bookShakunVA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookShakunVA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(List));
            }
            ViewData["AuthorId"] = new SelectList(_context.Author, "Id", "Id", bookShakunVA.AuthorId);
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Id", bookShakunVA.CategoryId);
            ViewData["PublisherId"] = new SelectList(_context.Publisher, "Id", "Id", bookShakunVA.PublisherId);
            ViewData["RankId"] = new SelectList(_context.Rank, "Id", "Id", bookShakunVA.RankId);
            ViewData["StatusId"] = new SelectList(_context.Status, "Id", "Id", bookShakunVA.StatusId);
            return View(bookShakunVA);
        }

        // GET: Admin/Books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookShakunVA = await _context.Book.FindAsync(id);
            if (bookShakunVA == null)
            {
                return NotFound();
            }
            ViewData["AuthorId"] = new SelectList(_context.Author, "Id", "Id", bookShakunVA.AuthorId);
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Id", bookShakunVA.CategoryId);
            ViewData["PublisherId"] = new SelectList(_context.Publisher, "Id", "Id", bookShakunVA.PublisherId);
            ViewData["RankId"] = new SelectList(_context.Rank, "Id", "Id", bookShakunVA.RankId);
            ViewData["StatusId"] = new SelectList(_context.Status, "Id", "Id", bookShakunVA.StatusId);
            return View(bookShakunVA);
        }

        // POST: Admin/Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,AuthorId,PublisherId,Year,Price,StatusId,Annotation,CategoryId,Img,RankId")] BookShakunVA bookShakunVA)
        {
            if (id != bookShakunVA.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookShakunVA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookShakunVAExists(bookShakunVA.Id))
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
            ViewData["AuthorId"] = new SelectList(_context.Author, "Id", "Id", bookShakunVA.AuthorId);
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Id", bookShakunVA.CategoryId);
            ViewData["PublisherId"] = new SelectList(_context.Publisher, "Id", "Id", bookShakunVA.PublisherId);
            ViewData["RankId"] = new SelectList(_context.Rank, "Id", "Id", bookShakunVA.RankId);
            ViewData["StatusId"] = new SelectList(_context.Status, "Id", "Id", bookShakunVA.StatusId);
            return View(bookShakunVA);
        }

        // GET: Admin/Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookShakunVA = await _context.Book
                .Include(b => b.Author)
                .Include(b => b.Category)
                .Include(b => b.Publisher)
                .Include(b => b.Rank)
                .Include(b => b.Status)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookShakunVA == null)
            {
                return NotFound();
            }

            return View(bookShakunVA);
        }

        // POST: Admin/Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookShakunVA = await _context.Book.FindAsync(id);
            _context.Book.Remove(bookShakunVA);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(List));
        }

        private bool BookShakunVAExists(int id)
        {
            return _context.Book.Any(e => e.Id == id);
        }
    }
}
