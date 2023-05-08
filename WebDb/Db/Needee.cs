using System;
using System.Collections.Generic;

#nullable disable

namespace WebDb.Db
{
    public partial class Needee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Education { get; set; }
        public bool? IsMarried { get; set; }
        public string Job { get; set; }
        public string Notes { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
