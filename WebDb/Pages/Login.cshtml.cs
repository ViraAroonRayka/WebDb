using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using WebDb.Db;

namespace WebDb.Pages
{
    public class LoginModel : PageModel
    {
        private readonly CharitySystemContext _context = new CharitySystemContext();
        public void OnGet()
        {
        }
        public void OnPost(string username, string password)
        {
            User user = _context.Users.Where(u => u.Username == username && u.Password == password).SingleOrDefault();
            if (user != null)
            {
                //TempData["UserId"] = user.Id;
                //TempData["RoleId"] = user.RoleId;
                HttpContext.Session.SetString("UserId", user.Id.ToString());
                HttpContext.Session.SetString("RoleId", user.RoleId.ToString());

                HttpContext.Session.Remove("UserId");
                HttpContext.Session.Remove("RoleId");
            }
            else
            {
                ViewData["Error"] = "نام کاربری یا رمز عبور اشتباره است";
            }
        }
    }
}
