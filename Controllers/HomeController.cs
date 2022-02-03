using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FilmCollectionMission4.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmCollectionMission4.Controllers
{
    public class HomeController : Controller
    {
        private MovieInfo DaContext { get; set; }

        public HomeController(MovieInfo someName)
        {
            DaContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            ViewBag.CategoryList = DaContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Movies(ApplicationResponse ar)
        {
            ViewBag.New = true;

            if (ModelState.IsValid)
            {
                DaContext.Add(ar);
                DaContext.SaveChanges();

                return View("Confirmation", ar);
            }
            else //if invalid
            {
                ViewBag.CategoryList = DaContext.Categories.ToList();

                return View(ar);
            }

        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        public IActionResult MovieList()
        {
            var applications = DaContext.Responses.Include(x => x.Category)
                .ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.CategoryList = DaContext.Categories.ToList();

            var application = DaContext.Responses.Single(x => x.MovieID == movieid);

            ViewBag.New = false;

            return View("Movies", application);
        }

        [HttpPost]
        public IActionResult Edit(ApplicationResponse blah)
        {
            DaContext.Update(blah);
            DaContext.SaveChanges();

            ViewBag.New = false;

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var application = DaContext.Responses.Single(x => x.MovieID == id);

            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse todelete)
        {
            DaContext.Responses.Remove(todelete);
            DaContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

    }
}
