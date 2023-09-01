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
    public class EducationsController : Controller
    {
        private readonly ApplicationContext _context;

        public EducationsController(ApplicationContext context)
        {
            _context = context;
        }

        

        // GET: Educations/Create
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

        // POST: Educations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,XcourseName,XIIcourseName,UGcourseName,PGcourseName,OthercourseName,XcollegeName,XIIcollegeName,UGcollegeName,PGcollegeName,OthercollegeName,Xpercent,XIIpercent,UGpercent,PGpercent,Otherpercent,Description1,year1,Description2,year2,program,Institute,duration,percentage,seminarname,seminarconductby,seminarduration,title,company,client,skill,teamsize,role,personid")] Education education)
        {
            var latestPersonalDetailsId = _context.Private
      .OrderByDescending(p => p.Id)
      .Select(p => p.Id)
      .FirstOrDefault();

            // Populate ViewData with SelectList
            ViewData["personid"] = new SelectList(_context.Set<Private>(), "Id", "Email", latestPersonalDetailsId);
            _context.Add(education);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create","Passports");
            
        }
        private bool EducationExists(int id)
        {
          return (_context.Education?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
