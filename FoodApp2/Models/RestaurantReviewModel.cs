using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodApp2.Models
{
    public class RestaurantReviewModel
    {
        public int id { get; set; }
        [Range(1, 10)]
        // int Required by Default -> ValueType cannot be null
        public int Rating { get; set; }
        [Display(Name = "Reviewer Name")]
        [DisplayFormat(NullDisplayText = "anonymous")]
        public string ReviewerName { get; set; }
        [Required]
        [StringLength(1024)]
        public string Body { get; set; }
        public int RestaurantId { get; set; }
    }
}