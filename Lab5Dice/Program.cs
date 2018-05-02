using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Dice
{
    class Program
    {
        static void Main(string[] args)
        {Random rand = new Random();
            // Play again Y/N
            

            bool choice = true;
            while (choice)
            { 
                // Initiate Sides of Dice

                Console.WriteLine("How Many Sides would You Like on Your Dice?");
                int x = int.Parse(Console.ReadLine());

                int die1 = rand.Next(1, x + 1);
                int die2 = rand.Next(1, x + 1);

                Console.WriteLine($"Your Roll on Dice 1 = {die1}\nYour Roll on Dice 2 = {die2}");

                Console.WriteLine("Would you Like to Run This Program Again? y/n");
                string option = Console.ReadLine().ToLower();
                if (option == "n")
                {
                    break;
                }

            }

        }
    }
}
