using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeGame
{
    static internal class BorderLineLimit
    {
        ///█ ■
        public static void Borders(int screenwidth, int screenheight)
        {
            for (int i = 0; i <= screenheight; i++)
            {
                //left and right border
                Console.SetCursorPosition(0, i + 1);
                Console.Write("█");
                Console.SetCursorPosition(screenwidth, i + 1);
                Console.Write("█");
            }

            for (int i = 0; i <= screenwidth; i++)
            {
                // top and below border
                Console.SetCursorPosition(i, 0);
                Console.Write("■");
                Console.SetCursorPosition(i, screenheight + 1);
                Console.Write("■");
            }
        }
    }
}
