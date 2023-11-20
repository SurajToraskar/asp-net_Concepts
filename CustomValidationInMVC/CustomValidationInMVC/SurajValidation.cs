using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomValidationInMVC
{
    public class SurajValidation:ValidationAttribute
    {
        protected override  ValidationResult IsValid(object value,ValidationContext validationContext)
        {
            if(value!=null){
                string message = value.ToString();
                if (message.Contains("suraj"))
                {
                    return ValidationResult.Success;
                }
            }
            ErrorMessage = ErrorMessage ?? validationContext.DisplayName+  "Field must contain Suraj";
            return new ValidationResult(ErrorMessage);
        }
    }
}