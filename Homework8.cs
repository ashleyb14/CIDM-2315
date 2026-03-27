using System.Runtime.InteropServices.Marshalling;

namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer(customerName: "Alice", customerAge: 33, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus2 = new Customer(customerName: "Bob", customerAge: 23, customerCity: "Amarillo", customerCredit: 226);
        Customer cus3 = new Customer(customerName: "Cathy", customerAge: 45, customerCity: "Amarillo", customerCredit: 89.0);
        Customer cus4 = new Customer(customerName: "David", customerAge: 58, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus5 = new Customer(customerName: "Jack", customerAge: 28, customerCity: "Canyon", customerCredit: 561.6);
        Customer cus6 = new Customer(customerName: "Tom", customerAge: 36, customerCity: "Canyon", customerCredit: 98.4);
        Customer cus7 = new Customer(customerName: "Tony", customerAge: 24, customerCity: "Canyon", customerCredit: 18.5);
        Customer cus8 = new Customer(customerName: "Sam", customerAge: 35, customerCity: "Canyon", customerCredit: 228.3);

        Customer[] customer_list = {cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8};

        //Call Q1 method 
        TotalCredits(customer_list);
        //Call Q2 method
        AmarilloAverageAge(customer_list);
        //Call Q3 method
        CanyonAge(customer_list);
    }
    //Q1 method
    public static void TotalCredits(Customer[] customer_list)
    {
        double total = 0;
        foreach(Customer cus in customer_list)
        {
            total += cus.customerCredit;
        }
        Console.WriteLine($"Q1: The total credits: {total}");
    }
    //Q2 method
    public static void AmarilloAverageAge(Customer[] customer_list)
    {
        double total = 0;
        double count = 0;
        foreach(Customer cus in customer_list)
        {
            if(cus.customerCity == "Amarillo")
            {
                total += cus.customerAge;
                count++;
            }
        }
        if(count>0){
        double average = total/count;
        Console.WriteLine($"Q2: The average age of customers in Amarillo: {average}");
        }
        
    }
    //Q3 method
    public static void CanyonAge(Customer[] customer_list)
    {
        Console.Write("Q3: Customers who live in Canyon and over 30 years old: ");
        foreach(Customer cus in customer_list)
        {
            if(cus.customerCity == "Canyon")
            {
                if(cus.customerAge > 30)
                {
                    Console.Write($"{cus.customerName}, ");
                }
            }
        }
    }
}

//Q0 class
class Customer
{
    public string customerName{set;get;} = string.Empty;
    public int customerAge{set;get;} = 0;
    public string customerCity{set;get;} = string.Empty;
    public double customerCredit{set;get;} = 0;

    public Customer (string customerName, int customerAge, string customerCity, double customerCredit)
    {
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }

}
