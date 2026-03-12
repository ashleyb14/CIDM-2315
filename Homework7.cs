namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        Customer Alice = new Customer(input_cus_id: 110, input_cus_name: "Alice", input_cus_age: 28);
        Customer Bob = new Customer(input_cus_id: 111, input_cus_name: "Bob", input_cus_age: 30);
        Alice.PrintCusInfo();
        Bob.PrintCusInfo();
        Alice.ChangeID(220);
        Bob.ChangeID(221);
        Alice.PrintCusInfo();
        Bob.PrintCusInfo();
        Alice.CompareAge(Bob);
    }
}

class Customer
{
    private int cus_id;
    public string cus_name;
    public int cus_age;
    public Customer(int input_cus_id, string input_cus_name, int input_cus_age)
    {
        cus_id = input_cus_id;
        cus_name = input_cus_name;
        cus_age = input_cus_age;
    }
    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }
    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer: {cus_id}; name: {cus_name}, age: {cus_age}");
    }
    public void CompareAge(Customer objCustomer)
    {
        if(this.cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older");
        }
        else
        {
            Console.WriteLine($"{objCustomer.cus_name} is older");
        }
    }
}
