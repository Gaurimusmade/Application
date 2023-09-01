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
    public class PrivatesController : Controller
    {
        private readonly ApplicationContext _context;

        public PrivatesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Privates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Privates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullName,FatherName,Email,PhoneNumber,Nationality,SecurityNumber,PANNumber,BirthDate,PlaceOfBirth,MaritalStatus,Gender")] Private @private)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@private);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create","Addinfoes");
            }
            return View(@private);
        }

        private bool PrivateExists(int id)
        {
          return (_context.Private?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
