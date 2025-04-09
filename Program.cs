using System.ComponentModel.Design;

namespace Functions
{
    internal class Program
    {
        public static string EvenOdd(int num1)
        {
            int result;
            result = num1 % 2;

            if (result == 0) {
                {
                    return "The Number is Even";
                } 

               else  

                {
                    return "The Number is Odd";
                }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
                Console.WriteLine("Hello, World!");
                Console.WriteLine("Enter the number of operation:");
                Console.WriteLine("1. Even or Odd ");
                Console.WriteLine("2. Largest of Three Numbers  ");
                int choice = int.Parse(Console.ReadLine());
            }
    }
}
