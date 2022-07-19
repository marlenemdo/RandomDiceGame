using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_dice_game
{
    internal class Program
    {
        static readonly Random _random = new Random();
        static void Main(string[] args)
        {
            KastaTärning(_random.Next(1, 10), " <-- times || sides --> ", _random.Next(1, 10));
        }

        static void KastaTärning(int KastTärning, string bokstavD, int tärningSidor)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ROLL THE DICE!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---RULES---");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1. The program will roll the dice for you. It will give a random number for the amount the times the dice will roll, and for the amount of sides it will have each time. The format is [Times the dice roll] + [Sides the dice have]");
                Console.WriteLine("2. You get point every time the dice rolls!");
                Console.WriteLine("3. The game is over if the dice has more than 6 sides - then you get 0 points.");
                Console.WriteLine();
                Console.WriteLine("GOOD LUCK!");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Roll the dice:");
                Console.Write(KastTärning + bokstavD + tärningSidor);
                Console.WriteLine();
                Console.WriteLine();

                if (tärningSidor <= 6)
                {
                    int sum = 0;
                    int[] kast = new int[KastTärning];
                    for (int i = 0; i < KastTärning; i++)
                    {
                        kast[i] = _random.Next(1, tärningSidor);
                        Console.WriteLine("Roll " + i + " gives you: " + kast[i]);
                        sum += kast[i];
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine($"Total points: {sum}");
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("GAME OVER! Your dice has more than 6 sides!");
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }  
}
