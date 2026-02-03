using System.Security.Cryptography.X509Certificates;

namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        // Code for Q1
        Console.WriteLine("Input an integer:");
        int N = Convert.ToInt16(Console.ReadLine());
        int i = 3;
        while(i<N)
        {
            if(N%i==0)
            {
                Console.WriteLine("N is non-prime");
                break;
            }
            i++;
        }
        if (N==i)
        {
            Console.WriteLine("N is prime");
        }

        // Code for Q2
        Console.WriteLine("Assign an int value to N:");
        int X = Convert.ToInt16(Console.ReadLine());
        for(int row=0; row < X; row++){
            for(int col=0; col< X; col++)
            {
                Console.Write("#");
            }
            Console.WriteLine("");
        }

        //Code for Q3
        Console.WriteLine("Assign an int value to N:");
        int y = Convert.ToInt16(Console.ReadLine());
        for(int row = 0; row < y; row++){
            for(int col=0; col <= row; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        
    }
}