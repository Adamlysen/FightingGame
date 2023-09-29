using System;
using System.Diagnostics;
using System.Security;

namespace bajshora
{

    class Program
    {

        public static void Main(string[] args)
        {


            Console.WriteLine("Welcome!");
            Console.WriteLine("Do you want to play the FightingGame?");

            string play = Console.ReadLine();

            while (play.ToUpper() != "YES")
            {

                if (play.ToUpper() == "YES")
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
            Console.WriteLine();

            int p1hp = 100;
            int p2hp = 100;

            Thread.Sleep(2500);




            while (p1hp >= 0 && p2hp >= 0)
            {


                int p1damage = generator.Next(31);
                int p2damage = generator.Next(31);

                Console.WriteLine($"{name1}: {p1hp} hp");

                Console.WriteLine($"{name2}: {p2hp} hp");

                Thread.Sleep(2500);
                Console.WriteLine();
                Console.WriteLine($"{name1} deals {p1damage}");

                p2hp = p2hp - p1damage;

                if (p1damage <= 10)
                {

                    Console.WriteLine("How can you be that bad???");
                    Console.WriteLine($"Only {p1damage}???");
                    Console.WriteLine();
                }
                else if (p1damage > 10 && p1damage < 20)
                {

                    Console.WriteLine("Good Work!");
                    Console.WriteLine();
                }
                else
                {

                    Console.WriteLine("A MAGNIFICENT ROPENIS ATTACK!!!");
                    Console.WriteLine();
                }

                Thread.Sleep(2500);

                Console.WriteLine($"{name2} deals {p2damage}");

                p1hp = p1hp - p2damage;

                if (p2damage <= 10)
                {

                    Console.WriteLine("How can you be that bad???");
                    Console.WriteLine($"Only {p2damage}???");
                    Console.WriteLine();
                }
                else if (p2damage > 10 && p2damage < 20)
                {

                    Console.WriteLine("Good Work!");
                    Console.WriteLine();
                }
                else
                {

                    Console.WriteLine("A MAGNIFICENT ROPENIS ATTACK!!!");
                    Console.WriteLine();
                }

                Thread.Sleep(2500);

                if (p1hp > 0 && p2hp < 0)
                {

                    Console.WriteLine($"{name1} wins!");
                    Console.WriteLine("Press enter to exit");

                }
                else if (p1hp < 0 && p2hp > 0)
                {

                    Console.WriteLine($"{name1} wins!");
                    Console.WriteLine("Press enter to exit");

                }


            }


        }


    }


}