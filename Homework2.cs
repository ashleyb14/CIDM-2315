using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        // Code for Q1
        Console.WriteLine("Please input a letter grade:");
        string letter = Console.ReadLine();
        switch (letter)
        {
            case "A":
            Console.WriteLine("GPA point: 4.0");
            break;
            case "B":
            Console.WriteLine("GPA point: 3.0");
            break;
            case "C":
            Console.WriteLine("GPA point: 2.0");
            break;
            case "D":
            Console.WriteLine("GPA point: 1.0");
            break;
            case "F":
            Console.WriteLine("GPA point: 0");
            break;

            default:
            Console.WriteLine("Wrong Letter Grade!");
            break;
        
        }

        // Code for Q2
        Console.WriteLine("Please input the first number:");
        string num1 = Console.ReadLine();
        int num1_int = Convert.ToInt16(num1);
        Console.WriteLine("Please input the second number:");
        string num2 = Console.ReadLine();
        int num2_int = Convert.ToInt16(num2);
        Console.WriteLine("Please input the third number:");
        string num3 = Console.ReadLine();
        int num3_int = Convert.ToInt16(num3);

        if (num1_int < num2_int)
        {
            if (num1_int < num3_int){
                Console.WriteLine($"The smallest value is: {num1_int}");
            } else{
                Console.WriteLine($"The smallest value is: {num3_int}");
            }
        } else if (num2_int < num3_int){
            Console.WriteLine($"The smallest value is: {num2_int}");
        } else{
            Console.WriteLine($"The smallest value is: {num3_int}");
        }

        // Code for the Bonus question
        Console.WriteLine("Please input a year:");
        string year = Console.ReadLine();
        int year_int = Convert.ToInt16(year);
        if(year_int%4 == 0){
            if(year_int%100 == 0){
                if(year_int%400 == 0){
                    Console.WriteLine($"{year_int} is a Leap Year.");
                } else{
                    Console.WriteLine($"{year_int} is not a Leap Year.");
                }
            } else{
                Console.WriteLine($"{year_int} is a Leap Year.");
            }
        } else{
          Console.WriteLine($"{year_int} is not a Leap year.");  
        }
    }
}             

