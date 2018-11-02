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
        OdeToFoodDb _db = new OdeToFoodDb();
        
        //Model Binder parameter aliasing, while looking for restaurantId with prefix id(Routing engine only knows id)
        public ActionResult Index([Bind(Prefix="id")] int restaurantId)
        {
            var restaurant = _db.Restaurants.Find(restaurantId);
            if(restaurant != null)
            {
                return View(restaurant);
            }
            return HttpNotFound();
        }

        [HttpGet]
        public ActionResult Create(int restaurantId)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = _db.Reviews.Find(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(RestaurantReviewModel review)
        {
            if (ModelState.IsValid)
            {
                _db.Reviews.Add(review);
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = review.RestaurantId });
            }
            return View(review);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }

        [HttpPost]
        //Exclude -> Prevent erroneous POST requests from editing the model (Mass assignment/Overposting)
        public ActionResult Edit( RestaurantReviewModel review)
        {
            if (ModelState.IsValid)
            {
                //Do not insert new record into DB. Update existing record. 
                _db.Entry(review).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = review.RestaurantId });
            }
            return View(review);
        }
    }
}
