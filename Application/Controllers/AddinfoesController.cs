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
    public class AddinfoesController : Controller
    {
        private readonly ApplicationContext _context;

        public AddinfoesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Addinfoes/Create

       

        public IActionResult Create()
        {
            var latestPersonalDetailsId = _context.Private
      .OrderByDescending(p => p.Id)
      .Select(p => p.Id)
      .FirstOrDefault();

            // Populate ViewData with SelectList
            ViewData["personid"] = new SelectList(_context.Set<Private>(), "Id", "Email", latestPersonalDetailsId);

            //ViewData["personid"] = new SelectList(_context.Set<Private>(), "Id", "Email");
            return View();
        }

        // POST: Addinfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AddressLine1,AddressLine2,ZipCode,City,State,Country,PermanentAddressLine1,PermanentAddressLine2,PermanentZipCode,PermanentCity,PermanentState,PermanentCountry,Name,RelationshipType,Age,personid")] Addinfo addinfo)
        {
            var latestPersonalDetailsId = _context.Private
      .OrderByDescending(p => p.Id)
      .Select(p => p.Id)
      .FirstOrDefault();
            ViewData["personid"] = new SelectList(_context.Set<Private>(), "Id", "Email", latestPersonalDetailsId);

            // ViewData["personid"] = new SelectList(_context.Set<Private>(), "Id", "Email", addinfo.personid);
            _context.Add(addinfo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create","Educations");
            
           
        }


        private bool AddinfoExists(int id)
        {
          return (_context.Addinfo?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
