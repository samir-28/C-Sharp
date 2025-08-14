using System;

public class Employee
{
    private string firstName;
    private string lastName;
    private double salary;

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public double Salary 
    {
        get { return salary; }
        set { salary = value; }
    }

    public Employee(string fname, string lname, double initialSalary)
    {
        FirstName = fname;
        LastName = lname;
        Salary = initialSalary;
    }

    public void DisplayFullName()
    {
        Console.WriteLine($"Employee Name: {firstName} {lastName}");
    }

    public void DisplaySalary()
    {
        Console.WriteLine($"Current Salary: {salary}");
    }

    public void IncreaseSalary(double amount)
    {
        salary += amount; 
        Console.WriteLine($"Salary increased by: {amount}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Employee Task\n");

        Employee emp = new Employee("Ram", "Bahadur", 20000);

        emp.DisplayFullName();
        emp.DisplaySalary();

        Console.WriteLine();

        emp.FirstName = "Hari";
        emp.IncreaseSalary(5000);

        Console.WriteLine();

        emp.DisplayFullName();
        emp.DisplaySalary();
    }
}
