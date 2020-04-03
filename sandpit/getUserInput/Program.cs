using System;

namespace getUserInput
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
