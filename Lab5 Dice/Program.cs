using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Dice
{
    public
        class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome to the Grand Circus Casino!");
            Random diceThrows = new Random();
            string rollAgainAnswer;
            //loop starts here
            
                Console.WriteLine("Roll the dice? (y/n)");
                string rollDiceAnswer = Console.ReadLine();
                int rollCounter = 1;

            do
            {
                Console.WriteLine("Roll " + rollCounter + ":");
                int diceNumber1 = diceThrows.Next(1, 7);
                int diceNumber2 = diceThrows.Next(1, 7);
                Console.WriteLine(diceNumber1);
                Console.WriteLine(diceNumber2);

                if(diceNumber1==1 && diceNumber2==1)
               { Console.WriteLine("Snake Eyes!"); }

                if (diceNumber1 == 6 && diceNumber2 == 6)
                { Console.WriteLine("Box Cars!"); }

                if (diceNumber1 + diceNumber2==7||
                    diceNumber1 + diceNumber2==2 ||
                    diceNumber1 + diceNumber2==3)
                { Console.WriteLine("Craps, You Lose!"); }

                rollCounter++;

                Console.WriteLine("Roll again?(y/n)");
                rollAgainAnswer = Console.ReadLine();
            } while ("y" == rollAgainAnswer);
            Console.WriteLine("Goodbye!");


        }
    }
}

