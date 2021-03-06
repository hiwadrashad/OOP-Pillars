using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeekOpdrachtDependencyInjection.Business.Entities;
using WeekOpdrachtDependencyInjection.Business.Interfaces;

namespace WeekOpdrachtDependencyInjection.Controllers
{
    public class MoviePageController : Controller
    {
        // GET: MoviePageController
        private readonly IMovieRepository _movieRepository;
        public MoviePageController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public IActionResult FormPage()
        {
            try
            {
                Movie DTO = new Movie();
                return View(DTO);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                Movie DTO = new Movie();
                return View(DTO);
            }
        }

        [HttpPost]
        public IActionResult FormPage(Movie DTO)
        {
            try
            {
                _movieRepository.Add(DTO);
                return RedirectToAction("SucessPage");
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                return RedirectToAction("FormPage");
            }
        }


        public IActionResult SucessPage()
        {
            try
            {
                return View();
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                return RedirectToAction("FormPage");
            }
        }

        // GET: MoviePageController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MoviePageController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MoviePageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MoviePageController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MoviePageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MoviePageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MoviePageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
