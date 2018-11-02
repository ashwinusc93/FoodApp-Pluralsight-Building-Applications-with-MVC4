using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodApp2.Models
{
    public class Restaurant
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        // One to Many relationship. Load muliple reviews for one restaurant
        public virtual ICollection<RestaurantReviewModel> Reviews { get; set; }
    }
}