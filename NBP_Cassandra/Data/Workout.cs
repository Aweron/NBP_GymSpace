using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_Cassandra.Data
{
    class Workout
    {
        public string WorkoutID { get; set; }
        public string MemberID { get; set; }
        public string GymName { get; set; }
        public string Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Exercise { get; set; }
    }
}
