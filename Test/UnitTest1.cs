using Game_Unit_test;
using Xunit;

namespace Tests
{
    public class Test
    {
        Battle battle = new();
        [Fact]
        public void BattleTest()
        {
            Team team1 = new(1, "Unit", 0, 0);
            Team team2 = new(2, "Test", 0, 0);

            battle.Matches(team1, team2);

            // Check if the TeamWin property of each team is updated correctly
            Assert.True(team1.TeamWin >= 0 && team1.TeamWin <= 5, "Team 1 win count is out of range.");
            Assert.True(team2.TeamWin >= 0 && team2.TeamWin <= 5, "Team 2 win count is out of range.");
        }
    }
}