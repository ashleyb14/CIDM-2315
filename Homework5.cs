using System.Data;
using System.Diagnostics;

namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        //Call Q1 Method
        int inputA, inputB;
        int result = LargestNumber(out inputA, out inputB);
        Console.WriteLine($"a = {inputA}; b = {inputB}");
        Console.WriteLine($"The largest number is: {result}");

        //Call Q2 Method
        int input1, input2, input3, input4;
        int max1 = LargestNumber(out input1, out input2);
        int max2 = LargestNumber(out input3, out input4);
        Console.WriteLine($"a = {input1}; b = {input2}; c = {input3}; d = {input4}");
        if(max1 > max2)
        {
            Console.WriteLine($"The largest number is: {max1}");
        }
        else
        {
            Console.WriteLine($"The largest number is: {max2}");
        }

        //Call Q3 Methods
        createAccount();

    }

    //Q1 & Q2 Method
    static int LargestNumber (out int A, out int B)
    {
        Console.WriteLine("Please input two integers:");
        A = Convert.ToInt16(Console.ReadLine());
        B = Convert.ToInt16(Console.ReadLine());
        if (A > B)
        {
            return A;
        }
        else
        {
            return B;
        }
            
    }

    //Q3 Methods
    static bool checkAge (int birth_year)
    {
        int current_year = 2026;
        int age = current_year - birth_year;
        if(age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void createAccount()
    {
        Console.WriteLine("Enter your username:");
        string username = Console.ReadLine();
        Console.WriteLine("Enter your password");
        string password1 = Console.ReadLine();
        Console.WriteLine("Enter your password again:");
        string password2 = Console.ReadLine();
        Console.WriteLine("Enter your birth year:");
        int birthyear = Convert.ToInt16(Console.ReadLine());
        bool ageCheck = checkAge(birthyear);
        if(ageCheck == true)
        {
            if(password1 == password2)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }
    
}
