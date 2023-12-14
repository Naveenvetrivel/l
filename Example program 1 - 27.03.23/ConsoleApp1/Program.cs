namespace ConsoleApp1
{ 
using System;
class Employee
{
    public int id, salary;
    public string name, designation;

    public Employee(int id, string name)
    {
        this.id = id;
        this.name = name;    
    }

    public Employee(int id, string name, string designation, int salary):this(id,name)
    {
        this.designation = designation;
        this.salary = salary;
    }
    public void display()
    {
        Console.WriteLine(id + " " + name + " " + designation + " " + salary);
    }
    class EmployeeDetails
    {
            public static void Main(string[] args)
            {
                Employee emp1 = new Employee(001, "Shru", "HR", 60000);
                Employee emp2 = new Employee(002, "Ishu", "Manager", 40000);
                Employee emp3 = new Employee(003, "Liz", "CEO", 70000);
                Employee emp4 = new Employee(004, "Hosh", "Developer", 50000);

                emp1.display();
                emp2.display();
                emp3.display();
                emp4.display();
            }

        }
    }
}