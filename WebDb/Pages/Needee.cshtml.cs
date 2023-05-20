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
        
        public bool isRegisterMode;
        private readonly CharityDatabaseContext _context = new CharityDatabaseContext();
        public Needee needee;
        public void OnGet()
        {
            string id = Request.Query["Id"].ToString();
            if (!string.IsNullOrEmpty(id)){
                int needeeId = Convert.ToInt32(id);
                isRegisterMode = false;
                needee = _context.Needees.FirstOrDefault(n => n.Id == needeeId);
                if(needee == null)
                {
                    ViewData["Error"] += "اطلاعات مددجو با این شناسه یافت نشد";
                }
                    
            }
            else
            {
                isRegisterMode = true;
            }

        }
        public void OnPost()
        {
            if (isRegisterMode)
            {
                string firstName = Request.Form["FirstNameTextBox"];
                string lastName = Request.Form["LastNameTextBox"];
                string nationalCode = Request.Form["NationalCodeTextBox"];

                string gender = Request.Form["GenderSelect"];
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
                    //Id = ++id
                });
                charityDatabaseContext.SaveChanges();
            }
            else
            {
                Response.Redirect("Needees");
            }
        }


    }
}
