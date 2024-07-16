using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeGame
{
    internal static class DummyAccounts
    {
        static List<string> playerNames = new List<string>();
        private static void userNames()
        {
            playerNames.Add("Fionah143");
            playerNames.Add("Maxie001");
            playerNames.Add("Jet024");
            playerNames.Add("Guest001");
            playerNames.Add("return previous selection");
        }

        public static void printUsers()
        {
            Console.Clear();
            Console.WriteLine("___________________________________________________");
            Console.WriteLine("                Game initialization                ");
            Console.WriteLine("___________________________________________________");
            Console.WriteLine("Login an account first in order to play the game: \n");

            if (playerNames.Contains("Fionah143") && playerNames.Contains("Maxie001") && playerNames.Contains("Jet024") && playerNames.Contains("Guest001") && playerNames.Contains("return previous selection")) { }
            else { userNames(); }

            for (int i = 0; i < playerNames.Count - 1; i++)
            {
                Console.WriteLine($"Press {i + 1} to login: {playerNames[i]}");
            }
            Console.WriteLine($"Press 5 to {playerNames[4]}");

        }
        public static void checkingUsers(int action)
        {
            //int fionahScore, maxieXcore, jetScore, guessScore;
            switch (action)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Note: Each cherry is to equivalent to 2 points.");
                    Console.WriteLine("Warning: Challenge begins after 5 cherries. Goodluck!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Playing as Fionah143....");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Note: Each cherry is to equivalent to 2 points.");
                    Console.WriteLine("Warning: Challenge begins after 5 cherries. Goodluck!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Playing as Maxie001....");
                break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Note: Each cherry is to equivalent to 2 points.");
                    Console.WriteLine("Warning: Challenge begins after 5 cherries. Goodluck!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Playing as Jet024....");
                break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Note: Each cherry is to equivalent to 2 points.");
                    Console.WriteLine("Warning: Challenge begins after 5 cherries. Goodluck!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Playing as Guest001....");
                break;
                case 5:
                    MenuOptions.Selection();
                    break;
                default:
                    break;
            }
        }
    }
}
