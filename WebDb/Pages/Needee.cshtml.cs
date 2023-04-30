using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebDb.Pages
{
    public class NeedeeModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost()
        {
            string firstName = Request.Form["FirstNameTextBox"];
            string lastName = Request.Form["LastNameTextBox"];
            int nationalCode = 0;
            bool result= Int32.TryParse( Request.Form["NationalCodeTextBox"],out nationalCode);

            ViewData["NeedeeInfo"] = firstName + " " + lastName + " " + nationalCode;
        }


    }
}
