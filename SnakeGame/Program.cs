using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Program
    {
       /* static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        } */
        static void Main(string[] args)
        {
            CPoint p1 = new CPoint();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            p1.Draw();

            CPoint p2 = new CPoint();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            p2.Draw();
            Console.ReadLine();
        }
    }
}
