using System;

namespace MethodExamples
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(returnCongrats());


            int result;

            result = NumberSquared(4);
            Console.WriteLine("The number squred is");
            Console.WriteLine(result);
        }
        static string returnCongrats()
        {
            return "Congratulations!";
        }
        static int NumberSquared(int x)
        {
            return x * x;
        }
    }
}
