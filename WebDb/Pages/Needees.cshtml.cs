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
    }
}
