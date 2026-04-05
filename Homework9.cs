using System.ComponentModel.Design;
using System.Dynamic;
using System.Numerics;
using System.Security.Cryptography;

namespace Homework9;

class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");
        Dictionary<string, double> Gradebook = new Dictionary<string, double>();
        Gradebook.Add("Alice", 4.0);
        Gradebook.Add("Bob", 3.6);
        Gradebook.Add("Cathy", 2.5);
        Gradebook.Add("David", 1.8);

        if (Gradebook.ContainsKey("Tom"))
        {
            Console.WriteLine($"Tom's Grade: {Gradebook["David"]}");
        }
        else
        {
            Gradebook.Add("Tom", 3.3);
        }

        double total = 0;
        int count = 0;
        foreach(var stu in Gradebook)
        {
            total += stu.Value;
            count++;
        }

        double avgGPA = total/count;
        Console.WriteLine($"The average GPA is: {avgGPA}");
        
        foreach(var student in Student.student_list)
        {
            string studentName = student.GetName();
            if(Gradebook.ContainsKey(studentName))
            {
                double GPA = Gradebook[studentName];
                if(GPA > avgGPA)
                {
                    student.PrintInfo();
                }
            }
        }
    }
}

class Student
{
    public static List<Student> student_list = new List<Student>();
    private int studentID {get;set;}
    private string studentName {get;set;}
    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }

    public Student(int inputID, string inputName)
    {
        studentID = inputID;
        studentName = inputName;
        student_list.Add(this);
    }

    public string GetName()
    {
        return studentName;
    }
}
