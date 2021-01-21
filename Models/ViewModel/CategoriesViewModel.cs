using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcDEMO.Models.ViewModel
{
    public class CategoriesViewModel : ValidationAttribute
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "類別名稱為必填")]
        [Display(Name = "類別名稱")]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        //public string Picture { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return ValidationResult.Success;
        }
    }
}