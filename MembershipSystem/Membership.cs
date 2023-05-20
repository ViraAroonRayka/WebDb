using System.Linq;
using WebDb.Db;

namespace MembershipSystem
{
    public class Membership
    {
        private readonly CharitySystemContext _context;
        public Membership(CharitySystemContext context)
        {
            _context = context;
        }
        public bool Login(string username, string password)
        {
            // ثبت تلاش این کاربر در ورود به سیستم جهت جلوگیری از ورود رمز عبور غلط به دفعات متعدد

            //بررسی اینکه آیا روج نام کاربری و رمز عبور داده شده در پایگاه داده معتبر است یا خیر
            User user = _context.Users.Where(u => u.Username == username && u.Password == password).SingleOrDefault();
            // برگرداندن مقدار
            return user != null ? true : false;
        }
        public void ForgetPassword(string username)
        {

        }
        public void Logout(string username)
        {

        }
    }
}
