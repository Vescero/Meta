using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsReset
{
    class State
    {
        public decimal Population { get; set; } // Население
        public decimal Area { get; set; }       // Территория

        public static State operator +(State s1, State s2)
        {
            return new State { Area = s1.Area + s2.Area, Population = s1.Population + s2.Population };
        }

        public static bool operator > (State s1, State s2)
        {
            return s1.Area > s2.Area;
        }
        public static bool operator < (State s1, State s2)
        {
            return s1.Area < s2.Area;
        }
    }
}
