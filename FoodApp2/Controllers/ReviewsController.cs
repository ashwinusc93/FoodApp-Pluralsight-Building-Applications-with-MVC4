using FoodApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodApp2.Controllers
{
    public class ReviewsController : Controller
    {
        // GET: Reviews
        public ActionResult Index()
        {
            var model = _reviews.OrderBy(r => r.Country).Select(r => r);
            return View(model);
        }

        // GET: Reviews/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reviews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reviews/Create
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

        // GET: Reviews/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reviews/Edit/5
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

        // GET: Reviews/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reviews/Delete/5
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
        // Only for demo purpose in Module 4
        static List<RestaurantReviewModel> _reviews = new List<RestaurantReviewModel>
        {
            new RestaurantReviewModel
            {
                id = 1,
                Name ="Dominos",
                City = "Bangalore",
                Country = "India",
                Rating = 9
            },
            new RestaurantReviewModel
            {
                id = 1,
                Name ="Pizza Hut",
                City = "Bangalore",
                Country = "India",
                Rating = 8
            },
            new RestaurantReviewModel
            {
                id = 1,
                Name ="Onesta",
                City = "Bangalore",
                Country = "India",
                Rating = 6
            },
        };

    }
}
