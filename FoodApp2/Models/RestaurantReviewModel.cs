using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodApp2.Models
{
    public class RestaurantReviewModel
    {
        public int id { get; set; }
        public int Rating { get; set; }

        public string Body { get; set; }
        public int RestaurantId { get; set; }
    }
}