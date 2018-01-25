using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18Years:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            var customer = (Customer)validationContext.ObjectInstance;


            if(customer.MembershipTypeId == 1)
            {
                return ValidationResult.Success;
            }
            else
            {
                if (customer.BirthDate == null)
                    return new ValidationResult("Birthdate is Required");
                else
                {
                    var today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    System.TimeSpan age = today.Subtract((DateTime)customer.BirthDate);


                    if (age.Days > 18*365)
                    {
                        return ValidationResult.Success;
                    }
                    else
                    {
                        return new ValidationResult("Sorry you are only eligible for Pay as You Go Membership Type");
                    }
                    
                }

            }
            
        }
    }
}