using System.Data;
using System.Diagnostics;
using System.Globalization;

namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        //Call Q1_method()
        Console.WriteLine("Please input a number:");
        int a = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input a second number:");
        int b = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(Comparison(a,b));

        //Call Q2_method()
        Console.WriteLine("Please input an integer:");
        int N = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please select a shape: enter '1' for left or '2' for right):");
        int shape = Convert.ToInt16(Console.ReadLine());
        PrintTriangle(N, shape);
    }

    //Q1_method
    static string Comparison(int x, int y)
    {
        if (x > y)
        {
            return $"The largest number is {x}";
        }
        else
        {
            return $"The largest number is {y}";
        }
    }

    //Q2_method
    static void PrintTriangle(int N, int shape)
    {
        if(shape == 1)
        {
            Console.WriteLine($"N is {N}; shape is left");
            for(int row = 0; row < N; row++){
              for(int col = 0; col < row; col++){
                Console.Write("*");     
                }  
                Console.WriteLine("");
            }
        }
        else if(shape == 2){
            Console.WriteLine($"N is {N}; shape is right");
            for(int row = 1; row <= N; row++){
                for(int col = 0; col < N-row; col++)
                {
                    Console.Write(" ");
                }
                for(int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
