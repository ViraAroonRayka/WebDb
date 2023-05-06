using System;
using System.Collections.Generic;

#nullable disable

namespace WebDb.Db
{
    public partial class Table
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string Gender { get; set; }
    }
}
