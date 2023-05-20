using System;
using System.Collections.Generic;

#nullable disable

namespace WebDb.Db
{
    public partial class User
    {
        public User()
        {
            Needees = new HashSet<Needee>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Needee> Needees { get; set; }
    }
}
