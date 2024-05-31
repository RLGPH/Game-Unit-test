namespace Game_Unit_test
{


    public class Program
    {

        public static Team[] teams = new Team[]
        {
        new Team(1, "Team A", 0, 0),
        new Team(2, "Team B", 0, 0),
        new Team(3, "Team C", 0, 0)
        };
        
        public static void Main(string[] args)
        {
            Battle battle = new Battle();
            Console.WriteLine("Press \"Enter to run or escape to close\"");
            //used to select what to do
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Enter)
            {
                battle.Matches(teams[0], teams[1]);

                battle.Matches(teams[0], teams[2]);

                battle.Matches(teams[1], teams[2]);
                Console.ReadLine();
            }
            else if (keyInfo.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine(":oh you pressed anything but what you were asked to" +
                    " good for you a real rull breaker");

                battle.Matches(teams[0], teams[1]);

                battle.Matches(teams[0], teams[2]);

                battle.Matches(teams[1], teams[2]);
                Console.ReadLine();
            }
        } 
    } 
}