using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_workshop.GameObjects
{
    public class Point
    {
        public Point(int LeftX, int TopY)
        {
            this.LeftX = LeftX;
            this.TopY = TopY;
        }
        public int LeftX { get; set; }
        public int TopY { get; set; }

        public void Draw(char symbol)
        {
            Console.SetCursorPosition(this.LeftX, this.TopY);
            Console.WriteLine(symbol);
        }
        public void Draw(int leftX, int topY, char symbol)
        {
            Console.SetCursorPosition(leftX, topY);
            Console.WriteLine(symbol);

        }
    }
}
