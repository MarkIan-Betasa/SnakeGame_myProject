using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace snakeGame
{
    internal static class MenuOptions
    {
        static List<string> menuChoices = new List<string>();
        static int validValue = 0;
        private static void Choices()
        {
            menuChoices.Add("Start");
            menuChoices.Add("Player's history");
            menuChoices.Add("Quit game");
        }
       
        public static void Selection()  
        {
            Console.WriteLine("\nWelcome to the Console SNAKE GAME" +
                "\ncreated by: MacMac" +
                "\n");

            if (menuChoices.Contains("Start") && menuChoices.Contains("Player's history") && menuChoices.Contains("Quit game")) { }
            else { Choices(); }

            for (int i = 0; i < menuChoices.Count; i++)
            {
                Console.WriteLine($"Press {i + 1} to {menuChoices[i]}");
            }

            int ii = 0;
            while (true)
            {
                bool valid = int.TryParse(Console.ReadLine(), out validValue);

                if (!valid || validValue <= 0 || validValue >= 4)
                {
                    Console.Clear();
                    Console.WriteLine("\nWelcome to the Console SNAKE GAME" +
                    "\ncreated by: MacMac" +
                    "\n");

                    for (int i = 0; i < menuChoices.Count; i++)
                    {
                        Console.WriteLine($"Press {i + 1} to {menuChoices[i]}");
                    }
                    ii++;

                    if (ii == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Maximum failed attempts reached. Snake game automatically exited.");
                        break;
                    }
                }
                else { break; }
            }
            ToNextSelection(validValue);
        }

        static int correctValue = 0;
        static int currentScore = 0;
        public static void ToNextSelection(int respond)
        {
            int i = 0;
            while (true)
            {
                switch (respond)
                {
                    case 1:
                        i = 0;
                        while (true)
                        {
                            DummyAccounts.printUsers(); 
                            bool real = int.TryParse(Console.ReadLine(), out correctValue);  //-- will receive the logins

                            if (!real || correctValue <= 0 || correctValue >= 6)
                            {
                                Console.WriteLine("Invalid input. Please try again.");
                                i++;
                            }
                            else
                            {
                                Console.Clear();
                                DummyAccounts.checkingUsers(correctValue);
                                currentScore = InitializeGame();
                                InitializeGame();
                                break;
                            }
                            if (i == 5)
                            {
                                Console.Clear();
                                Console.WriteLine("Maximum failed attempts reached. Snake game automatically exited.");
                                break;
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        PlayerHistory.ListScores(correctValue, currentScore);
                        Console.SetCursorPosition(0, 11);
                        Console.WriteLine("Press 1 to return to main menu");

                        i = 0;
                        while (true)
                        {
                            bool valid = int.TryParse(Console.ReadLine(), out correctValue);

                            if (!valid || correctValue != 1)
                            {
                                Console.Clear();
                                PlayerHistory.ListScores(correctValue, currentScore);
                                Console.SetCursorPosition(0, 11);
                                Console.WriteLine("Press 1 to return to main menu");
                                i++;
                            }
                            else { Console.Clear(); Selection(); }
                            if (i == 5)
                            {
                                Console.Clear();
                                Console.WriteLine("Maximum failed attempts reached. Snake game automatically exited.");
                                break;
                            }
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write($"Quitting game in ");
                        ExitTimeForQuit();
                        Console.WriteLine("\nGame quit.");
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
                break;
            }
        }
        public static int InitializeGame()
        {
            Console.Write($"Initializing game in ");
            ExitTimeForStart();
            Console.Clear();
            SnakeCons SnakeRules = new SnakeCons();
            SnakeRules.Movement();
            currentScore = SnakeRules.GetScore();
            return currentScore;
        }
        public static void ExitTimeForQuit()
        {
            List<int> Countdown = new List<int>();
            for (int i = 3; i > 0; i--)
            {
                Console.CursorVisible = false;
                Countdown.Add(i);
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b");
                Console.Write(" ");
                Console.Write("\b");
            }
        }
        public static void ExitTimeForStart()
        {
            List<int> Countdown = new List<int>();
            for (int i = 5; i > 0; i--)
            {
                Console.CursorVisible = false;
                Countdown.Add(i);
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b");
                Console.Write(" ");
                Console.Write("\b");
            }
        }
    }
}
    

