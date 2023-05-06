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

        }

    }
}
