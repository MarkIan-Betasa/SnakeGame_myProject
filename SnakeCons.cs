using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace snakeGame
{
    internal class SnakeCons
    {
        int screenwidth = 50, screenheight = 20;
        int lengthLimiter = 5;
        static int score = 0;
        static int validNumber = 0;
        static double timeElapsed = 0;
        int cherryX = 0, cherryY = 0;

        bool gameover = false;
        //wil check later if this is still necessary
        String movement = "Up"; 
        String buttonChecker = "no"; 

        List<int> XposMovement = new List<int>(); 
        List<int> YposMovement = new List<int>();
        Random randomPos = new Random();
        SnakeSnake Snake;
        
    
        public SnakeCons() 
        {
            Snake = new SnakeSnake();
            Snake.xposition = screenwidth / 2;
            Snake.yposition = screenheight / 2;
            cherryX = randomPos.Next(2, screenwidth - 2);
            cherryY = randomPos.Next(2, screenheight - 2);
        }
        
        public void Movement()
        {
            score = 0;
            while (!gameover)
            {
                //resets the Console
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                BorderLineLimit.Borders(screenwidth, screenheight);

                //cherry +2 score +1length
                Console.ForegroundColor = ConsoleColor.White;

                //iterates and checks for gameover
                for (int i = 0; i < XposMovement.Count; i++)
                {
                    Console.SetCursorPosition(XposMovement[i], YposMovement[i]);
                    Console.Write("¦");

                    if (Snake.xposition == cherryX && Snake.yposition == cherryY)
                    {
                        score += 2;
                        lengthLimiter++;
                        cherryX = randomPos.Next(2, screenwidth - 2);
                        cherryY = randomPos.Next(2, screenheight - 2);
                    }

                    else if (XposMovement[i] == cherryX && YposMovement[i] == cherryY)
                    {
                        cherryX = randomPos.Next(2, screenwidth - 2);
                        cherryY = randomPos.Next(2, screenheight - 2);
                    }

                    if (Snake.xposition == XposMovement[i] && Snake.yposition == YposMovement[i])
                    {
                        gameover = true;
                    }
                }

                if (gameover)
                {
                    break;
                }

                Console.SetCursorPosition(Snake.xposition, Snake.yposition);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("■");
                Console.SetCursorPosition(cherryX, cherryY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("■");
                Console.CursorVisible = false;
                DateTime time1 = DateTime.Now;
                buttonChecker = "no";

                if (XposMovement.Count >= 10) 
                { 
                    timeElapsed = 100;
                    if (XposMovement.Count >= 20) { timeElapsed = 50; }
                }
                else { timeElapsed = 200; }

                while (!gameover)
                {
                    if ((DateTime.Now - time1).TotalMilliseconds > timeElapsed) { break; }
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo keyPress = Console.ReadKey(true);
                        if (keyPress.Key.Equals(ConsoleKey.UpArrow) && movement != "Down" && buttonChecker == "no")
                        {
                            movement = "Up";
                            buttonChecker = "yes";
                        }
                        if (keyPress.Key.Equals(ConsoleKey.RightArrow) && movement != "Left" && buttonChecker == "no")
                        {
                            movement = "Right";
                            buttonChecker = "yes";
                        }
                        if (keyPress.Key.Equals(ConsoleKey.LeftArrow) && movement != "Right" && buttonChecker == "no")
                        {
                            movement = "Left";
                            buttonChecker = "yes";
                        }
                        if (keyPress.Key.Equals(ConsoleKey.DownArrow) && movement != "Up" && buttonChecker == "no")
                        {
                            movement = "Down";
                            buttonChecker = "yes";
                        }
                    }
                }
                XposMovement.Add(Snake.xposition);
                YposMovement.Add(Snake.yposition);

                switch (movement)
                {
                    case "Up":
                        Snake.yposition--;
                        if (Snake.yposition <= 0) Snake.yposition = screenheight;
                        break;
                    case "Right":
                        Snake.xposition++;
                        if (Snake.xposition >= screenwidth) Snake.xposition = 1;
                        break;
                    case "Left":
                        Snake.xposition--;
                        if (Snake.xposition <= 0) Snake.xposition = screenwidth - 1;
                        break;
                    case "Down":
                        Snake.yposition++;
                        if (Snake.yposition >= screenheight + 1) Snake.yposition = 1;
                        break;
                }
                
                if (XposMovement.Count > lengthLimiter)
                { 
                    XposMovement.RemoveAt(0);
                    YposMovement.RemoveAt(0);
                }
            }
            Console.SetCursorPosition(screenwidth / 5, screenheight / 2);
            Console.WriteLine($"Game over, Score: {score}");
            Console.SetCursorPosition(screenwidth / 5, screenheight / 2 + 1);
            SelectionAfterGame();

            //PlayerHistory.ListScores(respond, Snake.score);

            //int retry = 0;
            //while (true)
            //{
            //    SelectionAfterGame();
            //    retry++;

            //    if (retry > 1) { Environment.Exit(0); break; }
            //}
            
        }
        public int GetScore()
        {
            return score;
        }
        public void SelectionAfterGame()
        {
            List<string> anotherOption = new List<string>() { "play again", "main menu"};

            Console.SetCursorPosition(0, screenheight + 2);
            Console.WriteLine("Choose next action: ");

            for (int i = 0; i < anotherOption.Count; i++)
            {
                Console.WriteLine($"Press {i + 1} to {anotherOption[i]}");
            }

            int ii = 0;
            while (true)
            {
                bool valid = int.TryParse(Console.ReadLine(), out validNumber);

                if (!valid|| validNumber <= 0 || validNumber >= 3)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    ii++;
                }
                else { break; }
                if (ii == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Maximum failed attempts reached. Snake game automatically closing.");
                }
            }

            switch (validNumber)
            {
                case 1:
                    Console.Clear();
                    MenuOptions.InitializeGame();
                    break;
                case 2:
                    Console.Clear();
                    MenuOptions.Selection();
                    break;
                default:
                    break;
            }
        }
    }
    public class SnakeSnake
    {
        public int xposition { get; set; }
        public int yposition { get; set; }
    }
}
