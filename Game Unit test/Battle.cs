using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Unit_test
{
    public class Battle
    {
        static ScoreBoard board = new ScoreBoard();
        static Random rand = new Random();
        public void Matches(Team team1, Team team2)
        {
            team1.TeamWin = 0;
            team2.TeamWin = 0;
            int rounds = 0;
            do
            {
                int Teamnum2 = rand.Next(1, 4);

                int Teamnum1 = rand.Next(1, 4);
                if (Teamnum1 > Teamnum2)
                {
                    team2.Score++;

                    if (team2.Score == 3)
                    {
                        team2.TeamWin++;
                        team2.Score = 0;
                        rounds++;
                    }
                }
                else if (Teamnum1 < Teamnum2)
                {
                    team1.Score++;

                    if (team1.Score == 3)
                    {
                        team1.TeamWin++;
                        team1.Score = 0;
                        rounds++;
                    }
                }
                else
                {
                }
            } while (rounds < 10);
            board.scores(team1, team2);
        }
    }
}
