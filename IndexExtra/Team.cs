using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexExtra
{
    class Team
    {
        FootballPlayer[] footballTeam = new FootballPlayer[11];
        public FootballPlayer this [int index]
        {
            get
            {
                if (index >= 0 && index>footballTeam.Length)
                {
                    return null;    // Необходимо будет проверять на null
                }
                else
                {
                    return footballTeam[index];
                }
            }
            set { if (index >= 0 && index > footballTeam.Length) footballTeam[index] = value; }
        }
    }
}
