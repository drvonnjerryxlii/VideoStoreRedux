using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using VideoStoreRedux.Models;
using VideoStoreRedux.Data_Layer;

namespace VideoStoreRedux.Controllers
{
    public class MoviesController : Controller
    {
        static readonly MovieRepository repo = new MovieRepository();
        // GET: Movies
        public JsonResult Index()
        {
            List<Movie> movies = repo.All();

            if (movies.Count == 0)
            {
                return Json(new HttpResponseMessage(HttpStatusCode.NoContent), JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(movies, JsonRequestBehavior.AllowGet);
            }
            //return View();
        }

        // GET: Movies/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Movies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Movies/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Movies/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
