using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarInsurance.Data;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureesController : Controller
    {
        private readonly InsureeContext _context;

        public InsureesController(InsureeContext context)
        {
            _context = context;
        }

        // GET: Insurees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Insuree.ToListAsync());
        }

        // GET: Insurees/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insuree
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // GET: Insurees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Insurees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Id = Guid.NewGuid();
                insuree.Quote = CalculateQuote(insuree);

                _context.Add(insuree);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        // GET: Insurees/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insuree.FindAsync(id);
            if (insuree == null)
            {
                return NotFound();
            }
            return View(insuree);
        }

        // POST: Insurees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (id != insuree.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(insuree);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsureeExists(insuree.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        // GET: Insurees/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insuree
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // POST: Insurees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var insuree = await _context.Insuree.FindAsync(id);
            if (insuree != null)
            {
                _context.Insuree.Remove(insuree);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsureeExists(Guid id)
        {
            return _context.Insuree.Any(e => e.Id == id);
        }

        public decimal CalculateQuote(Insuree insuree)
        {
            decimal monthlyTotal = 50m; //$50 base total

            int age = CalculateAge(insuree.DateOfBirth); //calculate age

            if (age <= 18) //if statement that if your 18 or younger, $100 is added to your monthly total
            {
                monthlyTotal += 100;
            }
            else if (age >= 19 && age <= 25) //else if statement that if you are between 19-25, $50 is added to monthly total 
            {
                monthlyTotal += 50;
            }
            else if (age >= 26) //else if you are 26 or older, $25 is added to monthly total 
            {
                monthlyTotal += 25;
            }

            if (insuree.CarYear < 2000) //if your car is from before 2000, $25 is added to the monthly total 
            {
                monthlyTotal += 25;
            }
            else if (insuree.CarYear > 2015) //if your car was made before 2015, $25 is added to monthly total
            {
                monthlyTotal += 25;
            }
            if (insuree.CarMake.ToLower() == "porsche")//if your car model is a Porsche, $25 is added to the monthly total
            {
                monthlyTotal += 25;

                if (insuree.CarModel.ToLower() == "911 Carrera") //if it is also a 911 carrera, another $25 is added to monthly total
                {
                    monthlyTotal += 25;
                }
            }

            monthlyTotal += insuree.SpeedingTickets * 10; //tack on $10 to monthly total for every speeding ticket

            if (insuree.DUI) //if insuree has a DUI, the monthly total goes up by 25%
            {
                monthlyTotal *= 1.25m;
            }

            if (insuree.CoverageType.ToLower() == "full coverage") //if the insuree selects full coverage, tack on 50% to monthly total
            {
                monthlyTotal *= 1.50m;
            }

            insuree.Quote = monthlyTotal;

            return insuree.Quote;
        }

        private int CalculateAge(DateTime dateOfBirth)
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (dateOfBirth > DateTime.Now.AddYears(-age)) age--;
            return age;
        }

        //get: Insurees/admin
        public async Task<IActionResult> Admin()
        {
            // Fetch all insurees with quotes from the database
            var insurees = await _context.Insuree
                .Select(i => new
                {
                    i.FirstName,
                    i.LastName,
                    i.EmailAddress,
                    i.Quote
                })
                .ToListAsync();

            return View(insurees);
        }
    }


    }
