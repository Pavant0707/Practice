using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{//Design a simple login system in C# where users provide their username and password.
 //Use conditional statements to check the credentials and provide appropriate feedback, such as successful login, incorrect username, incorrect password, or account locked.
    class User
    {
        public string username {  get; set; }
        public int password { get; set; }
        public static List<User> GetInfo()
        {
            List<User> list = new List<User>()
            {
                new User{username="tom",password=123},
                new User{username="Ram",password=456},
                new User{username="pavan",password=789}
            };
            return list;
        }
        static void Main(string[] args)
        {
            var a=(from user in GetInfo() where user.username =="tom" select user).ToList();
            Console.WriteLine(a);
            Console.WriteLine("enter the password");
            int otp=Convert.ToInt32(Console.ReadLine());
            foreach (var item in a)
            {
                if (otp == 123)
                {
                    Console.WriteLine(item.username + " " + "password is correct and logrd in successful");
                }
                else
                {
                    Console.WriteLine("password is incorrect or account is locked");
                }
            }
        }
    }
}
