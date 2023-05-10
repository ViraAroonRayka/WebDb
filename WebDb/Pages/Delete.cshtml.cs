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
                string id = Request.Query["Id"].ToString();
                if (!string.IsNullOrEmpty(id))
                {
                    int needeeId = Convert.ToInt32(id);
                    Needee needeeToDelete = _context.Needees.FirstOrDefault(n => n.Id == needeeId);
                    if (needeeToDelete != null)
                    {
                        _context.Needees.Remove(needeeToDelete);
                        _context.SaveChanges();
                    }
                    else
                    {
                        ViewData["Error"] += "مددجویی با این شناسه یافت نشد\n";
                    }
                }                

            }
            catch(Exception ex)
            {
                ViewData["Error"] += ex.Message.ToString();
            }
        }

    }
}
