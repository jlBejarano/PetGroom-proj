using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetGroom.Data;
using PetGroom.Models;

namespace PetGroom.Controllers
{
    public class GroomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GroomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Groomers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Groomers.ToListAsync());
        }

        // GET: Groomers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groomer = await _context.Groomers
                .FirstOrDefaultAsync(m => m.GroomerId == id);
            if (groomer == null)
            {
                return NotFound();
            }

            return View(groomer);
        }

        // GET: Groomers/Create
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GroomerId,GroomerName")] Groomer groomer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(groomer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(groomer);
        }

        // GET: Groomers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groomer = await _context.Groomers.FindAsync(id);
            if (groomer == null)
            {
                return NotFound();
            }
            return View(groomer);
        }

        // POST: Groomers/Edit
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GroomerId,GroomerName")] Groomer groomer)
        {
            if (id != groomer.GroomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(groomer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroomerExists(groomer.GroomerId))
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
            return View(groomer);
        }

        // GET: Groomers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groomer = await _context.Groomers
                .FirstOrDefaultAsync(m => m.GroomerId == id);
            if (groomer == null)
            {
                return NotFound();
            }

            return View(groomer);
        }

        // POST: Groomers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var groomer = await _context.Groomers.FindAsync(id);
            _context.Groomers.Remove(groomer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroomerExists(int id)
        {
            return _context.Groomers.Any(e => e.GroomerId == id);
        }

        
        [HttpGet]

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Image ImageModel)
        {

            if (ModelState.IsValid)
            {
                _context.Add(ImageModel);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(ImageModel);

        }

        [HttpGet]

        public ActionResult GroomersImageView(int id, Image Image)
        {
            Image ImageModel = new Image();




            var applicationDbContext = _context.Images.Where(i => i.ImageId == id).FirstOrDefault();
            return View(ImageModel);

        }

    }
}
