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
    public class AssesmentsController : Controller
    {
        private readonly ApplicationContext _context;

        public AssesmentsController(ApplicationContext context)
        {
            _context = context;
        }

      
        // GET: Assesments/Create
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

        // POST: Assesments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,S1,S2,S3,S4,S5,W1,W2,W3,W4,W5,Hobby,Shortgoal,Longgoal,MpyAttendency,personid")] Assesment assesment)
        {
            var latestPersonalDetailsId = _context.Private
      .OrderByDescending(p => p.Id)
      .Select(p => p.Id)
      .FirstOrDefault();

            // Populate ViewData with SelectList
            ViewData["personid"] = new SelectList(_context.Set<Private>(), "Id", "Email", latestPersonalDetailsId);
            _context.Add(assesment);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create","Declarations");
        }
        private bool AssesmentExists(int id)
        {
          return (_context.Assesment?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
