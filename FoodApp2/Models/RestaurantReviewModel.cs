using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodApp2.Models
{
    // Approach 1 of Custom Validation (Attribute Specific Validation)
    /*public class MaxWordsAttribute : ValidationAttribute
    {
        private int _maxWords;
        public MaxWordsAttribute(int maxWords) : base("{0} has too many words")
        {
            _maxWords = maxWords;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var valueAsString = value.ToString();
                if(valueAsString.Split(' ').Length > _maxWords)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
            }
            return ValidationResult.Success;
        }
    }*/
    
    public class RestaurantReviewModel : IValidatableObject
    {
        public int id { get; set; }
        [Range(1, 10)]
        // int Required by Default -> ValueType cannot be null
        public int Rating { get; set; }
        [Display(Name = "Reviewer Name")]
        [DisplayFormat(NullDisplayText = "anonymous")]
        public string ReviewerName { get; set; }
        [Required(ErrorMessageResourceType = typeof(FoodApp2.Views.Home.Resources), ErrorMessageResourceName ="Greeting")]
        [StringLength(1024)]
        public string Body { get; set; }
        public int RestaurantId { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(Rating < 2 && ReviewerName.ToLower().StartsWith("ash"))
            {
                yield return new ValidationResult("Sorry this is not possible");
            }
        }
    }
}