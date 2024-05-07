using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    //Create a class hierarchy for employees in an organization.Define a base class Employee with properties such as Name, EmployeeId, and Salary.Derive classes such as Manager, Developer, and HR from the base class. Implement specific functionalities and properties for each derived class.
    public class Employee
    {
        public int Id { get; set; }
        public string Name {  get; set; }
        public int salary { get; set; }
        public  Employee(int  id,string Name,int salary)
        {
            this.Id = id;
            this.Name = Name;
            this.salary= salary;
        }
        public virtual void Display()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Id);
            Console.WriteLine(salary);
        }
        
        
    }
    public class Manager : Employee
    {
        public string Department {  get; set; }
        public Manager(int id, string Name, int salary,string department) : base(id, Name, salary)
        {
            Department = department;

        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(Department);
        }
    }
    public class Developer : Employee
    {
        public string Country {  get; set; }
        public Developer(int id, string Name, int salary, string country) : base(id, Name, salary)
        {
            this.Country = country;
        }
    }
    public class solution
    {
        static void Main(string[] args)
        {
            Manager manager =new Manager(1,"ram",10000,"It");
            Developer developer = new Developer(2, "sai", 100000, "df");
            Console.WriteLine("managr");
            manager.Display();

        }
    }
}
