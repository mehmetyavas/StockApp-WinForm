using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Utils.CustomAttributes
{
    public class PositiveNumberAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is decimal ) 
            {
                if ((int)value < 0) 
                {
                    throw new Exception("Value Must Be Positive!");
                }
            }

            return ValidationResult.Success;
        }

    }
}