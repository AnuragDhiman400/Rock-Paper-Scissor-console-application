using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperconsole
{
    class Program
    {

        // This is main method
        static void Main(string[] args)
        {
            
            int win = 0, loose = 0, tie = 0;

        again:
            //Random number generation
            Random rn = new Random();
            //Here range is defined for the random number generation
            int computer = rn.Next(1, 3);
            Console.WriteLine("Choose between rock,scissor,paper ");
            string player = Console.ReadLine();
            
                if (computer == 1)
                {
                    if (player == "rock")
                    {
                        Console.WriteLine("System choosed scissors,You won the game :)");
                        win++;
                    }
                    else if (player == "scissor")
                    {
                        Console.WriteLine("System choosed paper,You won the game :)");
                        win++;
                    } 
                    else if (player == "paper")
                    {
                        Console.WriteLine("System choosed rock,You won the game :)");
                        win++;
                    }
                    
                }
                if (computer == 2)
                {
                    if (player == "rock")
                    {
                        Console.WriteLine("System choosed rock,You tied the game :p");
                        tie++;
                    }
                    else if (player == "scissor")
                    {
                        Console.WriteLine("System choosed scissor,You tied the game :p");
                        tie++;
                    }
                    else if (player == "paper")
                    {
                        Console.WriteLine("System choosed paper,You tied the game :p");
                        tie++;
                    }
                    
                }
                if (computer == 3)
                {
                    if (player == "rock")
                    {
                        Console.WriteLine("System choosed paper,Sorry you loose :(");
                        loose ++;
                    }
                    else if (player == "scissor")
                    {
                        Console.WriteLine("System choosed rock,Sorry you loose :(");
                        loose++;
                    }
                    else if (player == "paper")
                    {
                        Console.WriteLine("System choosed scissor,Sorry you loose :(");
                        loose++;
                    }
               }
            Console.WriteLine("Number of wins :"+win);
            Console.WriteLine("Number of loose :" + loose);
            Console.WriteLine("Number of tie's :" + tie);
            Console.WriteLine("If you want to play again press 1 else 0");
            int choice =Convert.ToInt32(Console.ReadLine());

            //If the user selects "1" to play the game again
            if (choice == 1)
            {
                goto again;
            }
            else
            {
                
                Console.ReadKey();
            }
        }
    }
}
