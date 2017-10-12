﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeWindows
{

    class Program
    {
        
        enum Direction { Right, Down, Up, Left };

        static void Main(string[] args)
        {
            Direction direction;

            //Initialise the snake grid
            int[,] snakeGrid = new int[15,15];
            for (int i = 0; i < 15; i++)
            { for(int j = 0; j < 15; j++)
                {
                    snakeGrid[i,j] = 0;
                }
            }

            (int row, int column) snakePosition = (8, 8);
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.RightArrow:
                            direction = Direction.Right;
                            break;
                        case ConsoleKey.DownArrow:
                            direction = Direction.Down;
                            break;
                        case ConsoleKey.LeftArrow:
                            direction = Direction.Left;
                            break;
                        case ConsoleKey.UpArrow:
                            direction = Direction.Up;
                            break;
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                    }
                }


                if (Environment.TickCount % 400 == 0)
                {
                    //Move snake
                    for (int i = 0; i < 15; i++) { 
                        for(int j = 0; j < 15; j++) {
                            switch (Console.ReadKey(true).Key)
                        {
                        case direction = Direction.Right:
                            
                            break;
                        case direction = Direction.Down:
                            break;
                        case direction = Direction.Left:
                            break;
                        case direction = Direction.Up:
                            break;
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                        }
                        }
                    }
                    
                    //Initialise the length to 3.
                    snakeGrid[8,8] = 3;
                    snakeGrid[8,7] = 2;
                    snakeGrid[8,6] = 1;

                    //Update the snake grid
                    for (int i = 0; i < 15; i++)
                    { for(int j = 0; j < 15; j++)
                        {
                            //Console.Write(snakeGrid[i,j]);
                            //Format this properly
                            if (snakeGrid[i,j] > 0) {
                                Console.Write("+");
                            } else if (snakeGrid[i,j] < 0) {
                                Console.Write("x");
                            } else if (i == snakePosition.row && j == snakePosition.column) {
                                Console.Write("O");
                            }
                            } else {
                                Console.Write(".");
                            }
                        }
                        Console.Write("\n");
                    }
                }
            }
        }


    }
}
