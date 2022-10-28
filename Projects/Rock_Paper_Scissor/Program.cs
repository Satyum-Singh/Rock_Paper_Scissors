﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            Console.Write("Choose between ROCK, PAPER and SCISSORS:    ");
            inputPlayer = Console.ReadLine();
            inputPlayer = inputPlayer.ToUpper();

            Random rnd = new Random();

            randomInt = rnd.Next(1, 4);

            int scorePlayer=0,scoreCPU=0;

            switch (randomInt)
            {
                case 1:
                    inputCPU = "ROCK";
                    Console.WriteLine("Computer chose ROCK");
                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                    }
                    break;
                case 2:
                    inputCPU = "PAPER";
                    Console.WriteLine("Computer chose PAPER");
                    if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    else if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    }
                    break;
                case 3:
                    inputCPU = "SCISSORS";
                    Console.WriteLine("Computer chose SCISSORS");
                    if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    else if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid entry!");
                    break;
            }       
        }
    }
}