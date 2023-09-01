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
    public class CompaniesController : Controller
    {
        private readonly ApplicationContext _context;

        public CompaniesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Companies/Create
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

        // POST: Companies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CompanyName,CompanyAddress,Lastdesignation,Employmentperiod,Employecode,NameofRm,DepartmentofRm,EmailofRm,TelephoneofRm,NameofHr,EmailofHr,TelephoneofHr,EmploymentIsOf,AlternativeNameofRm,AlternativeDepartmentofRm,AlternativeEmailofRm,AlternativeTelephoneofRm,Reason,Agency,Remunerations,personid")] Company company)
        {
            var latestPersonalDetailsId = _context.Private
      .OrderByDescending(p => p.Id)
      .Select(p => p.Id)
      .FirstOrDefault();

            // Populate ViewData with SelectList
            ViewData["personid"] = new SelectList(_context.Set<Private>(), "Id", "Email", latestPersonalDetailsId);
            _context.Add(company);
                await _context.SaveChangesAsync();
            return RedirectToAction("Create","Assesments");
        }
       

        private bool CompanyExists(int id)
        {
          return (_context.Company?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
