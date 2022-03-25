using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_Ladder_Problem
{
    
    internal class Program
    {
        static void Main(string[] args)
        {

            int dicenum;

            Random random = new Random();
            dicenum = random.Next(1, 7);
            Console.WriteLine($"After rolling Dice,The number display on the Dice is : {dicenum}");

            Console.ReadLine();
        }
    }
}
