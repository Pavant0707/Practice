using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Question4
{

    //    Write a LINQ query to filter a list of numbers and select only the even numbers.
    //Write a LINQ query to filter a list of strings and select only the strings starting with a specific letter.
    //Write a generic method named Swap that takes two parameters of the same type and swaps their values
    //Create a login system that prompts the user to enter their username and password.
    //If the username and password match predefined values, display a welcome message.
    //Otherwise, display an error message.
    public class Program
    {
        public

        static void Main(string[] args)
        {
            try
            {
                if (Regex.IsMatch("password@123", @"^[A-Za-z0-9]+[@][0-9]{1,}$"))
                {
                    Console.WriteLine("welcome");
                }
                else
                {
                    throw new FormatException("Invaild password");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            int[] num = new int[] { 1, 2, 34, 6 };
            var a = from even in num where even % 2 == 0 select even;
            // var a = num.Where(n => n % 2 == 0);
            foreach (int i in a)
            {
                Console.WriteLine(i);

            }
           
            int c = 5;
            int b = 10;
            Swap(ref c, ref b);
            Console.WriteLine("after swaping" + "c:" + c + " " + "b:" + b);

            String[] name = { "tom", "arjun", "vivek" };
            var b2 = from emp in name where name.Contains("a") select emp;
            Console.WriteLine(b);
            foreach (var emp in b2)
            {
                Console.WriteLine(emp);
            }
        }

        private static void Swap<T>(ref T c, ref T b)
        {
            T temp = c;
            c = b;
            b = temp;
        }

    } 
}

