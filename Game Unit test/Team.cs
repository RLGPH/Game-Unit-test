using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Unit_test
{
    public class Team
    {
        public int ID { get; set; }
        public string TeamN { get; set; }
        public int Score { get; set; }
        public int TeamWin {  get; set; }
        public Team(int Id, string teamN, int score, int teamWin)
        {
            ID = Id;
            TeamN = teamN;
            Score = score;
            TeamWin = teamWin;
        }
    }

}
