namespace GME1011RedvsBlue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Epic Red vs. Blue Battle Sim!!!");
            Console.WriteLine("-------------------------------");

            Console.Write("How many members per team?: ");
            int numMembers = int.Parse(Console.ReadLine());

            Console.WriteLine("\nCreating teams...");

            int[] teamRed = new int[numMembers];
            int[] teamBlue = new int[numMembers];

            Console.WriteLine("\nPopulating teams...");

            Random rng = new Random();
            for(int i = 0; i < numMembers; i++)
            {
                teamRed[i] = rng.Next(1,101);
                teamBlue[i] = rng.Next(1, 101);
            }

            Console.WriteLine("\nWaging EPIC battle...");
            int teamRedWins = 0;
            int teamBlueWins = 0;
            int ties = 0;

            for(int i = 0; i < numMembers;i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Battle: " + (i+1) + ": ");
                if (teamRed[i] == teamBlue[i])
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("It's a tie!");
                    ties++;
                }
                else if (teamRed[i] > teamBlue[i])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Team Red gets a win!");
                    teamRedWins++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Team Blue all the way!");
                    teamBlueWins++;
                }
                System.Threading.Thread.Sleep(100);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nIn the end, " + numMembers + " battles were waged.");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Team Red wins: " + teamRedWins);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Team Blue wins: " + teamBlueWins);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ties: " + ties);


            Console.ForegroundColor = ConsoleColor.White;

            if (teamRedWins == teamBlueWins)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("In the end, it's a TIE!?!");
            }
            else if(teamRedWins > teamBlueWins)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("RED TEAM wins the day!!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("It's all BLUE TEAM today!!!");
            }

            Console.ForegroundColor = ConsoleColor.White;



        }
    }
}