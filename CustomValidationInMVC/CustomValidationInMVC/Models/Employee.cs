using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CustomValidationInMVC.Models
{
    public class Employee
    {
        [Required]
        public string Name { get; set; }

        [SurajValidation(ErrorMessage ="Suraj is Required")]
        public string Message { get; set; }
    }
}