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

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}
