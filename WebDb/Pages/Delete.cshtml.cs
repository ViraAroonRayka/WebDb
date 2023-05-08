using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebDb.Db;

namespace WebDb.Pages
{
    public class DeleteModel : PageModel
    {
        CharityDatabaseContext _context = new CharityDatabaseContext();
        
        public void OnGet()
        {

        }
        public void OnPost()
        {
            try
            {
                int needeeId = Convert.ToInt32(Request.Query["Id"]);
                Needee needeeToDelete = _context.Needees.First(n => n.Id == needeeId);

                _context.Needees.Remove(needeeToDelete);
                _context.SaveChanges();

            }
            catch(Exception ex)
            {
                ViewData["Error"] = ex.Message.ToString();
            }
        }

    }
}
