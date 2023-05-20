using System;
using System.Collections.Generic;

#nullable disable

namespace WebDb.Db
{
    public partial class Role
    {
        public Role()
        {
            RoleAccesses = new HashSet<RoleAccess>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RoleAccess> RoleAccesses { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
