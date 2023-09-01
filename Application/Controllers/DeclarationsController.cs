using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Application.Data;
using Application.Models;

namespace Application.Controllers
{
    public class DeclarationsController : Controller
    {
        private readonly ApplicationContext _context;

        public DeclarationsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Declarations
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.Declaration.Include(d => d.Private);
            return View(await applicationContext.ToListAsync());
        }

       
        // GET: Declarations/Create
        public IActionResult Create()
        {
            var latestPersonalDetailsId = _context.Private
      .OrderByDescending(p => p.Id)
      .Select(p => p.Id)
      .FirstOrDefault();

            // Populate ViewData with SelectList
            ViewData["personid"] = new SelectList(_context.Set<Private>(), "Id", "Email", latestPersonalDetailsId);
            return View();
        }

        // POST: Declarations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Signed,Name,Date,personid")] Declaration declaration)
        {
            var latestPersonalDetailsId = _context.Private
      .OrderByDescending(p => p.Id)
      .Select(p => p.Id)
      .FirstOrDefault();

            // Populate ViewData with SelectList
            ViewData["personid"] = new SelectList(_context.Set<Private>(), "Id", "Email", latestPersonalDetailsId);
            _context.Add(declaration);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
        }
        private bool DeclarationExists(int id)
        {
          return (_context.Declaration?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
