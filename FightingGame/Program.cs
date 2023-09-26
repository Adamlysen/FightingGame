using System;
using System.Diagnostics;

namespace bajshora
{

    class Program
    {

        public static void Main(string[] args)
        {
            

            Console.WriteLine("Welcome!");
            Console.WriteLine("Do you want to play the FightingGame?");

            string play = Console.ReadLine();

            while (play != "yes")
            {

                if (play == "no")
                {

                    return;

                }
                Console.Beep();

                Console.WriteLine("Yes or No?");

                play = Console.ReadLine();
            }

            Gameplay1();



        }




        public static void Gameplay1()
        {
            Random generator = new Random();
            

            Console.WriteLine("Enter Player 1 Name:");
            string name1 = Console.ReadLine();


            Console.WriteLine("Enter Player 2 Name:");
            string name2 = Console.ReadLine();

            Console.WriteLine("Press enter to start the game");
            Console.ReadLine();
            Console.WriteLine("The fight begins");
            Console.WriteLine($"{name1} and {name2} start engaging eachother");
            

            


        }


    }


}