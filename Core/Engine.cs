using Snake_workshop.Enums;
using Snake_workshop.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake_workshop.Core
{
   public class Engine
    {
        private Direction direction; 
      
        private Dictionary<Direction, Point> pointDirections;
        private Snake snake;
        private double speed;

        public Engine(Snake snake)
        {
            this.snake = snake;
            this.direction = Direction.right;
            this.pointDirections = new Dictionary<Direction, Point>()
            {
                {Direction.left,new Point(-1,0) },
                {Direction.right,new Point(1,0) },
                {Direction.up,new Point(0,-1) },
                {Direction.down,new Point(0,1) }
            };
            speed = 200;
        }
        public void Run()
        {
           
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    this.GetDirection();

                }
                bool tryMove = this.snake.TryMove(this.pointDirections[this.direction]);

                if (!tryMove)
                {
                    Console.WriteLine("Bye Bye");
                    Environment.Exit(0);
                }
                speed -= 0.5;
                Thread.Sleep((int)speed);
            }
        }

  
         
        private void GetDirection()
        {
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

            if (consoleKeyInfo.Key ==ConsoleKey.LeftArrow)
            {
                if (direction != Direction.right)
                {
                    direction = Direction.left;
                }
            }
          else  if (consoleKeyInfo.Key == ConsoleKey.RightArrow)
            {
                if (direction != Direction.left)
                {
                    direction = Direction.right;
                }
            }
            else if (consoleKeyInfo.Key == ConsoleKey.UpArrow)
            {
                if (direction != Direction.down)
                {
                    direction = Direction.up;

                }
            }
            else if (consoleKeyInfo.Key == ConsoleKey.DownArrow)
            {
                if (direction != Direction.up)
                {
                    direction = Direction.down;
                }
            }
        }
    }

}
