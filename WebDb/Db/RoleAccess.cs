using System;
using System.Collections.Generic;

#nullable disable

namespace WebDb.Db
{
    public partial class RoleAccess
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Route { get; set; }

        public virtual Role Role { get; set; }
    }
}
