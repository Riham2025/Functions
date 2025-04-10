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
        public static double CalculateDiscount(double originalPrice, double discountPercentage)
        {
            double discountAmount = (originalPrice * discountPercentage) / 100;
            double finalPrice = originalPrice - discountAmount;
            return finalPrice;
        }

        // Grading System
        public static string GetGrade(double marks)
        {
            if (marks >= 90)
            {
                return "A+";
            }
            else if (marks >= 80)
            {
                return "A";
            }
            else if (marks >= 70)
            {
                return "B+";
            }
            else if (marks >= 60)
            {
                return "B";
            }
            else if (marks >= 50)
            {
                return "C+";
            }
            else if (marks >= 40)
            {
                return "C";
            }
            else
            {
                return "F";
            }
        }

        // Swap Two Numbers 
        public static string SwapTwoNumbers(double num1, double num2)
        {

        }


        static void Main(string[] args)
        
        {
            Console.WriteLine("Hello, World!");
           
            Console.WriteLine("Enter the number of operation:");
            Console.WriteLine("1. Even or Odd ");
            Console.WriteLine("2. Largest of Three Numbers  ");
            Console.WriteLine("3. Celsius to Fahrenheit ");
            Console.WriteLine("4. Simple Discount Calculator ");
            Console.WriteLine("5. Grading System ");
            Console.WriteLine("6. Swap Two Numbers  ");
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
                    case 4:
                    Console.WriteLine("Enter Original Price");
                    double originalPrice = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Discount Percentage");
                    double discountPercentage = double.Parse(Console.ReadLine());
                    double finalPrice = CalculateDiscount(originalPrice, discountPercentage);
                    Console.WriteLine("Final Price after Discount: " + finalPrice);
                    break;

                case 5:
                    Console.WriteLine("Enter Marks");
                    double marks = double.Parse(Console.ReadLine());
                    string grade = GetGrade(marks);
                    Console.WriteLine("Grade: " + grade);
                    break;



            }



        }
 
    }    
}    
                    
        
        
       


