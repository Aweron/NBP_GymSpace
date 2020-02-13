using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_Cassandra.Data
{
    class Membership
    {
        public string MemberID { get; set; }
        public string LastsFrom { get; set; }
        public string LastsUntil { get; set; }
        public string Gym { get; set; }
    }
}
