using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebDb.Db;

namespace CharityDatabase.Pages
{
    public class NeedeesModel : PageModel
    {
        private readonly CharityDatabaseContext _context = new CharityDatabaseContext();
        public List<Needee> needees;
        public NeedeesModel()
        {
            needees = _context.Needees.ToList();
        }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            string searchTerm = Request.Form["SearchTextBox"].ToString();
            needees = search(searchTerm);
        }

        /// <summary>
        /// جستجو در پایگاه داده با عبارت جستجوی مشخص شده توسط کاربر
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <returns></returns>
        public List<Needee> search(string searchTerm)
        {
            List<Needee> foundNeedees = _context.Needees.Where(n => n.FirstName.Contains(searchTerm) ||
            n.LastName.Contains(searchTerm) || n.NationalCode.Contains(searchTerm)).OrderBy(n=>n.LastName).ToList();
            return foundNeedees;
        }


    }
}
