﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_workshop.GameObjects
{
    public abstract class Food : Point
    {
        private readonly Wall wall;
        private readonly char symbol;
        private readonly Random random;
        public Food(Wall wall, char symbol , int points) : base(0,0)
        {
            this.wall = wall;
            this.symbol = symbol;
            this.Points = points;
            this.random = new Random();
        }
        public int Points { get;private set; }

        public void setRandomPosition(Queue<Point> snakeElements)
        {
            this.LeftX = this.random.Next(1, this.wall.LeftX - 1);
            this.TopY = this.random.Next(1, this.wall.TopY - 1);

            bool isPartOfSnake = snakeElements.Any(x => x.LeftX == this.LeftX && x.TopY == this.TopY);
            while (isPartOfSnake)
            {
                this.LeftX = this.random.Next(1, this.wall.LeftX - 1);
                this.TopY = this.random.Next(1, this.wall.TopY - 1);

              isPartOfSnake = snakeElements.Any(x => x.LeftX == this.LeftX && x.TopY == this.TopY);
            }
            Console.BackgroundColor = ConsoleColor.Green;
            this.Draw(symbol);
            Console.BackgroundColor = ConsoleColor.White;

        }
    }
}
