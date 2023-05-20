using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Linq;
using WebDb.Db;

namespace WebDb.Pages
{
    public class EditModel : PageModel
    {
        private readonly CharityDatabaseContext _context = new CharityDatabaseContext();
        public Needee needeeToEdit;
        public EditModel()
        {

        }
        public void OnGet()
        {
            string id = Request.Query["Id"];
            if (!string.IsNullOrEmpty(id))
            {
                int idToEdit = Convert.ToInt32(id);
                needeeToEdit = _context.Needees.FirstOrDefault(n => n.Id == idToEdit);

            }
        }
        public void OnPost()
        {
            string id = Request.Query["Id"];
            if (!string.IsNullOrEmpty(id))
            {
                int idToEdit = Convert.ToInt32(id);
                needeeToEdit = _context.Needees.FirstOrDefault(n => n.Id == idToEdit);

            }
            try
            {
                if (needeeToEdit != null)
                {
                    needeeToEdit.FirstName = Request.Form["FirstNameTextBox"].ToString();
                    needeeToEdit.LastName = Request.Form["LastNameTextBox"].ToString();
                    needeeToEdit.NationalCode = Request.Form["NationalCodeTextBox"].ToString();
                    _context.SaveChanges();
                    Response.Redirect("Needees");
                }
            }
            catch (Exception ex)
            {
                ViewData["Error"] = ex.Message;
            }
            finally
            {
                _context.Dispose();
            }
        }
    }
}
