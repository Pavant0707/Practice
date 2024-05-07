using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
     class Employee
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public static List<Employee> GetAllEmployee()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1,Name="Tom", DateTime = new DateTime(2016,6,8)},
                new Employee() { Id = 2,Name="Ram", DateTime = new DateTime(2016,2,8)},
                new Employee() { Id = 3,Name="sai", DateTime = new DateTime(2024,5,8)},
                new Employee() { Id = 4,Name="allu sriesh", DateTime = new DateTime(2023,10,25)},
                new Employee() { Id = 5,Name="prabhas", DateTime = new DateTime(2024,6,8)}
            };
            return employees;
        }
        static void Main(string[] args)
        {
             var cuttoff=DateTime.Now.AddMonths(-6);
            var a = (from emp in GetAllEmployee() where emp.DateTime <= cuttoff select emp);
            foreach (var emp in a)
            {
                Console.WriteLine(emp.Name);
            }
        }
    }
}
