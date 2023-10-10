using System;
using System.Diagnostics;
using System.Security;
using System.Security.Cryptography;

namespace bajshora
{

    class Program
    {

        public static void Main(string[] args) // Main void som är huvuddelen i programmet
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




        public static void Gameplay1() // Här är själva spelet som kommer köras
        {
            Random generator = new Random();

            Console.WriteLine("Enter Player Name:");
            string name1 = Console.ReadLine();              // Namn på spelare 1

            Console.WriteLine("Select Enemy:");
            Console.WriteLine();
            Console.WriteLine("1 - ROPENIS");
            Console.WriteLine();
            Console.WriteLine("2 - HORUNGE");
            Console.WriteLine();
            Console.WriteLine("3 - SATTAR");

            string selectenemy = Console.ReadLine();
            string enemyplayer1 = "";

            if (selectenemy == "1")
            {

                enemyplayer1 = "ROPENIS";

            }

            else if (selectenemy == "2")
            {

                enemyplayer1 = "HORUNGE";

            }

            else if (selectenemy == "3")
            {

                enemyplayer1 = "SATTAR";
            }

            Console.WriteLine("Press enter to start the game");

            Console.ReadLine();



            Console.WriteLine("The fight begins");
            Console.WriteLine();

            int p1hp = 100;     // Hp för spelaren
            int p2hp = 100;     // Hp för Motståndaren

            Thread.Sleep(2500);




            while (p1hp >= 0 && p2hp >= 0)
            {


                int p1damage = generator.Next(31);
                int p2damage = generator.Next(31);

                Console.WriteLine($"{name1}: {p1hp} hp");

                Console.WriteLine($"{enemyplayer1}: {p2hp} hp");

                Thread.Sleep(2500);
                Console.WriteLine();
                Console.WriteLine($"{name1} deals {p1damage}");



                p2hp = p2hp - p1damage;

                if (p1damage <= 10)
                {

                    Console.WriteLine("FUGGIN TRAAAAASHHH BRO AHAHAHAHAHH!!!");
                    Console.WriteLine();
                }
                else if (p1damage > 10 && p1damage < 20)
                {

                    Console.WriteLine("Good Work!");
                    Console.WriteLine();
                }
                else
                {

                    Console.WriteLine("A MAGNIFICENT BOULLEEESSS ATTACK!!!");
                    Console.WriteLine();
                }

                Thread.Sleep(2500);

                Console.WriteLine($"{enemyplayer1} deals {p2damage}");

                p1hp = p1hp - p2damage;

                if (p2damage <= 10)
                {

                    Console.WriteLine("FUGGIN TRAAAAASHHH BRO AHAHAHAHAHH!!!");
                    Console.WriteLine();
                }
                else if (p2damage > 10 && p2damage < 20)
                {

                    Console.WriteLine("Good Work!");
                    Console.WriteLine();
                }
                else
                {

                    Console.WriteLine("A MAGNIFICENT BOULLEEESSS ATTACK!!!");
                    Console.WriteLine();
                }

                Thread.Sleep(2500);



            }

            if (p1hp >= 0 && p2hp <= 0)
            {

                Console.WriteLine("You win!");
                Console.WriteLine("Press enter to exit");
                Console.WriteLine();
                Console.ReadLine();
            }


        
                else if (p1hp< 0 && p2hp> 0)
                {

                    Console.WriteLine("You lost!");
                    Console.WriteLine("Press Enter to exit");
                    Console.WriteLine();
                    Console.ReadLine();

                }



}


    }


}