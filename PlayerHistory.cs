using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace snakeGame
{
    internal static class PlayerHistory
    {
        static int point1 = 0, point2 = 0, point3 = 0, point4 = 0;

        public static void ListScores(int respond, int score)
        {
            SnakeCons SnakeRules = new SnakeCons();
            score = SnakeRules.GetScore();
            switch (respond)
            {
                case 1:
                    point1 = score;
                    break;
                case 2:
                    point2 = score;
                    break;
                case 3:
                    point3 = score;
                    break;
                case 4:
                    point4 = score;
                    break;
                default:
                    break;
            }
            printingHistory();
        }

        public static void printingHistory()
        {
            const string stringFormat = " |{0, 38} {1, 8} {2,13}"; 
            Console.WriteLine("  ____________________________________________________________");
            Console.WriteLine(" |                       Players' History                     |");
            Console.WriteLine(" |____________________________________________________________|");
            Console.WriteLine(" |          Username                       Recent score       |");
            Console.WriteLine(" |------------------------------------------------------------|");
            Console.WriteLine(stringFormat, "Fionah143     ............ ", point1, "|");
            Console.WriteLine(stringFormat, "Maxie001      ............ ", point2, "|");
            Console.WriteLine(stringFormat, "Jet024        ............ ", point3, "|");
            Console.WriteLine(stringFormat, "Guest001      ............ ", point4, "|");
            Console.WriteLine(" |____________________________________________________________|");
        }
    }
}
