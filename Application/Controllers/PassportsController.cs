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
    public class PassportsController : Controller
    {
        private readonly ApplicationContext _context;

        public PassportsController(ApplicationContext context)
        {
            _context = context;
        }

       
        

        // GET: Passports/Create
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

        // POST: Passports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Number,Issuedate,Expirydate,PlaceofIssue,RfName,Rfcurrentcompany,Rfemail,Rftelephone,RsName,Rscurrentcompany,Rsemail,Rstelephone,Visa,Opentotravel,personid")] Passport passport)
        {
            var latestPersonalDetailsId = _context.Private
      .OrderByDescending(p => p.Id)
      .Select(p => p.Id)
      .FirstOrDefault();

            // Populate ViewData with SelectList
            ViewData["personid"] = new SelectList(_context.Set<Private>(), "Id", "Email", latestPersonalDetailsId);
            _context.Add(passport);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create","Companies");
            
        }

       
        private bool PassportExists(int id)
        {
          return (_context.Passport?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
