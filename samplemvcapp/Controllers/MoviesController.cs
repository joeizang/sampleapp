using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using samplemvcapp.Data;
using samplemvcapp.Models;

namespace samplemvcapp.Controllers
{
    public class MoviesController : Controller
    {
        private readonly SampleContext _context;


        public MoviesController(SampleContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            var result = await _context.Movies.AsNoTracking().ToListAsync();
            return View (result);
        }

        public ActionResult Details(int id)
        {
            return View ();
        }

        public ActionResult Create()
        {
            return View ();
        } 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Movie model)
        {
            if (!ModelState.IsValid) return View(model);
            _context.Movies.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        public ActionResult Edit(int id)
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }

        public ActionResult Delete(int id)
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
    }
}