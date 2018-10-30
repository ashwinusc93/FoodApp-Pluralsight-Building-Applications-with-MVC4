namespace FoodApp2.Migrations
{
    using FoodApp2.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FoodApp2.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "FoodApp2.Models.OdeToFoodDb";
        }

        protected override void Seed(FoodApp2.Models.OdeToFoodDb context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name,
                new Restaurant { Name = "Tandoor", City = "Bangalore", Country = "IN" },
                new Restaurant { Name = "Onesta", City = "Bangalore", Country = "IN" },
                new Restaurant
                {
                    Name = "Toit",
                    City = "Bangalore",
                    Country = "IN",
                    Reviews = new List<RestaurantReviewModel> { new RestaurantReviewModel { Rating = 7, Body = "Good Pizza", ReviewerName = "Ashwin" } }
                });
        }
    }
}
