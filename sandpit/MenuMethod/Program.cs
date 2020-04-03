using System;

namespace MenuMethod
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int selectionAttempts = 1;
            string gameChoice;
            
           

            for (int i = 1; i <= selectionAttempts; i++)
            {
                Console.WriteLine("Please Select a game: ");
                Console.WriteLine("1: Starter, 2: Age game, 3: Shopping, 4: Funfair ");
                gameChoice = Console.ReadLine();

                switch (gameChoice)
                {
                    case "1":
                        Console.WriteLine("Loading up starter method!");
                        starter();
                        break;
                    case "2":
                        Console.WriteLine("Loading up Age method!");
                        ageGame();
                        break;
                    case "3":
                        Console.WriteLine("Loading up Shopping method!");
                        shopping();
                        break;
                    case "4":
                        Console.WriteLine("Loading up Funfair game!");
                        funFair();
                        break;
                    default:
                        Console.WriteLine("You did not select a game");
                        break;




                }
            }

        }

        public static void starter()
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        static void ageGame()
        {
            string userName;
            int usersAge;
            string friendsName;
            int friendsAge;

            Console.Write("Enter your name: ");
            userName = Console.ReadLine();
            Console.Write("Enter your age: ");
            usersAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is " + userName + " and you are " + usersAge + " years old");
            Console.WriteLine();

            Console.WriteLine("Enter your friends age: ");
            friendsName = Console.ReadLine();
            Console.Write("Enter your friends age: ");
            friendsAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your friends name is " + friendsName + " and they are " + friendsAge + " years old");
            Console.ReadLine();

            Console.WriteLine("There are " + (usersAge + friendsAge) + " years between the two of you");
            Console.WriteLine();


        }
        public static void shopping()
        {
            string guacamoleResponse;
            bool isGuacamoleOnSale;
            double moneyInPocket;


            Console.Write("Is guacamole on sale? (Yes/No): ");
            guacamoleResponse = Console.ReadLine();


            if (guacamoleResponse == "yes")
                isGuacamoleOnSale = true;
            else
                isGuacamoleOnSale = false;

            Console.Write("How much money is in your pocket? : ");
            moneyInPocket = Convert.ToDouble(Console.ReadLine());

            if ((isGuacamoleOnSale && moneyInPocket >= 10) || moneyInPocket >= 100)
                Console.WriteLine("Let's go shopping! ");
            else
                Console.WriteLine("Let's stay home :( ");



        }
        public static void funFair()
        {
            int totalAttempts = 3;
            string doorChoice;

            for (int i = 1; i <= totalAttempts; i++)
            {
                Console.Write("Choose a door between 1-5 and win a prize! This is attempt number #" + i + ":");
                doorChoice = Console.ReadLine();

                switch (doorChoice)
                {
                    case "1":
                        Console.WriteLine("You won a balloon!");
                        break;
                    case "2":
                        Console.WriteLine("You won a stuffed animal!");
                        break;
                    case "3":
                        Console.WriteLine("You won a bicycle!");
                        break;
                    case "4":
                        Console.WriteLine("You won a car!");
                        break;
                    case "5":
                        Console.WriteLine("You won a million pounds!");
                        break;
                    default:
                        Console.WriteLine("That's not even a choice, you won nothing!");
                        break;




                }
            }
        }
       
    }
}



