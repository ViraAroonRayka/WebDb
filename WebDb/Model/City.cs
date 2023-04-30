using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDb.Model
{
    public class City
    {
        public string Name
        {
            get;
            set;
        }
        public Province province
        {
            get;
            set;
        }
    }
}
