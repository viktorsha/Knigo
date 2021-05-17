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
    public class PublishersController : Controller
    {
        private readonly AppDBContentShakunVA _context;

        public PublishersController(AppDBContentShakunVA context)
        {
            _context = context;
        }

        // GET: Admin/Publishers
        public async Task<IActionResult> List()
        {
            return View(await _context.Publisher.ToListAsync());
        }

        // GET: Admin/Publishers/Details/5
        

        // GET: Admin/Publishers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Publishers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PublisherName")] PublisherShakunVA publisherShakunVA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(publisherShakunVA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(List));
            }
            return View(publisherShakunVA);
        }

        // GET: Admin/Publishers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publisherShakunVA = await _context.Publisher.FindAsync(id);
            if (publisherShakunVA == null)
            {
                return NotFound();
            }
            return View(publisherShakunVA);
        }

        // POST: Admin/Publishers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PublisherName")] PublisherShakunVA publisherShakunVA)
        {
            if (id != publisherShakunVA.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(publisherShakunVA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PublisherShakunVAExists(publisherShakunVA.Id))
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
            return View(publisherShakunVA);
        }

        

        private bool PublisherShakunVAExists(int id)
        {
            return _context.Publisher.Any(e => e.Id == id);
        }
    }
}
