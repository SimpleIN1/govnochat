using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewChat3
{
    class Users
    {
        public Users()
        {

        }
        public string login { get;  set; }
        public byte[] image { get; set; }
        public bool status { get; set; }
        public bool StatusDeleted { get; set; }
    }
}
