using System.ComponentModel.Design;

namespace Functions
{
    internal class Program
    {
        public static string EvenOdd(int num1)
        // Even or Odd function
        {
            int result;
            result = num1 % 2;

            if (result == 0)
            {
                return "The Number is Even";
            }

            else

            {
                return "The Number is Odd";
            }


        }
        public static double LargestOfThree(double num1, double num2, double num3) {
            //largest of three numbers function
            double result = 0;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;
        }

        // Temperature Converter
        public static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }

        //. Simple Discount Calculator
        static void Main(string[] args)
        
        {
            Console.WriteLine("Hello, World!");
           
            Console.WriteLine("Enter the number of operation:");
            Console.WriteLine("1. Even or Odd ");
            Console.WriteLine("2. Largest of Three Numbers  ");
            Console.WriteLine("3. Celsius to Fahrenheit ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice) //add function
            {
                case 1:
                    Console.WriteLine("Enter The Number");
                    int num1 = int.Parse(Console.ReadLine());
                    string result = EvenOdd(num1);
                    Console.WriteLine(result);

                    break;

                case 2:
                    Console.WriteLine("Enter Three Numbers");
                    double num2 = double.Parse(Console.ReadLine());
                    double num3 = double.Parse(Console.ReadLine());
                    double num4 = double.Parse(Console.ReadLine());
                    double result1 = LargestOfThree(num2, num3, num4);
                    Console.WriteLine("Largest Number is: " + result1);

                    break;
                case 3:
                    Console.WriteLine("Enter Temperature in Celsius");
                    double celsius = double.Parse(Console.ReadLine());
                    double fahrenheit = CelsiusToFahrenheit(celsius);
                    Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
                    break;

            }



        }
 
    }    
}    
                    
        
        
       


