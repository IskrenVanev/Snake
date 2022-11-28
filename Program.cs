using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Snake_workshop.GameObjects;
using Snake_workshop.Utilities;
using Snake_workshop.Core;
using Snake_workshop.Enums;

namespace Snake_workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWindow.CustomizeConsole();


            Wall wall = new Wall(100,20);

            //Food food = new FoodDollar(wall);
            //food.setRandomPosition(new System.Collections.Generic.Queue<Point>());

            Snake snake = new Snake(wall);

            
            Engine engine = new Engine(snake);
            engine.Run();
        }
    }
}
