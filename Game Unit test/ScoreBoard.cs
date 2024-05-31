using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Unit_test
{
    public class ScoreBoard
    {
        //desplayed ui
        public void scores(Team team1, Team team2)
        {
            Console.WriteLine($"{team1.TeamN} VS {team2.TeamN}\n" +
                "______________________\n" +
                "Team Name | Rounds won\n" +
                $"{team1.TeamN}    | {team1.TeamWin}\n" +
                $"{team2.TeamN}    | {team2.TeamWin}\n" +
                "______________________\n");

        }
    }
}
