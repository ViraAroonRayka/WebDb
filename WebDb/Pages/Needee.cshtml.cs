using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebDb.Db;

namespace WebDb.Pages
{
    public class NeedeeModel : PageModel
    {
        int id = 0;
        public void OnGet()
        {
        }
        public void OnPost()
        {
            string firstName = Request.Form["FirstNameTextBox"];
            string lastName = Request.Form["LastNameTextBox"];
            string nationalCode = Request.Form["NationalCodeTextBox"];

            string gender =  Request.Form["GenderSelect"];
            if (gender.Equals("Male"))
            {
                ViewData["Gender"] = "Male";
            }
            else
            {
                ViewData["Gender"] = "Female";
            }

            ViewData["NeedeeInfo"] = firstName + " " + lastName + " " + nationalCode;
            
            CharityDatabaseContext charityDatabaseContext = new CharityDatabaseContext();
            charityDatabaseContext.Needees.Add(new Needee()
            {
                FirstName = firstName,
                LastName = lastName,
                Gender = gender,
                NationalCode = nationalCode,
                Id = ++id
            });
            charityDatabaseContext.SaveChanges();
        }


    }
}
