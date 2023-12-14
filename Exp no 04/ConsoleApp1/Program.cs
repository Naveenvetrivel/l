using System;
namespace employee
{
    class employee
    {
        public string name, designation;
        public int no_exp, salary, insurance;
        public double hra, ta, basic_pay;


        public employee(string name, string designation, int no_exp, int salary, int insurance)
        {
            this.name = name;
            this.designation = designation;
            this.no_exp = no_exp;
            this.salary = salary;
            this.insurance = insurance;

        }
        public void Salary()
        {
            hra = this.salary * 0.2;
            ta = this.salary * 0.1;
            basic_pay = this.salary + hra + ta - this.insurance;
        }
        public void display()
        {
            Console.WriteLine("Name of the employee is {0} having {1} years of experience, working as {2}", this.name, this.no_exp, this.designation);
            Console.WriteLine("Receives {0} of salary", basic_pay);
        }
    }
    class employeeDeatils
    {
        public static void Main(string[] args)
        {
            employee emp1 = new employee("Shru", "Data analyst", 12, 100000, 50000);
            emp1.Salary();
            employee emp2 = new employee("Gokul", "CEO", 15, 500000, 100000);
            emp2.Salary();

            emp1.display();
            emp2.display();
        }
    }

}
