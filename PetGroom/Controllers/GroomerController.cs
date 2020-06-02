using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetGroom.Data;
using PetGroom.Models;

namespace PetGroom.Controllers
{
    public class GroomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GroomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Image Image)
        {

            if (ModelState.IsValid)
            {
                _context.Add(Image);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            
            return View();
            
        }

        [HttpGet]

        public ActionResult View(int id)
        {
            Image imageModel = new Image();
            
               
            

           var  applicationDbContext = _context.Images.Where(i => i.ImageId == id).FirstOrDefault();
            return View(imageModel);
            
        }

       
    }
}