using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace Parctice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if (Regex.IsMatch("Ram@123.com", @"^[A-Za-z]+[@][A-Za-z0-9]+[.][A-Za-z]{2,3}"))
            //if(Regex.IsMatch("Ram@123",@"^\w+\[@]\d{1,}$"))
            //if (Regex.IsMatch("17/02/24",@"^[0-9]{0,2}[/]*[0-9]{0,2}[/]*[0-9]{0,4}$"))
            //if(Regex.IsMatch("AAA AAA",@"\w+[ ]*\w+$"))
             //if(Regex.IsMatch("https\\www.NTR.com",@"^(http(s)?[\\.])+(\w{ 3})+([.])*(\w)+[.]*(\w){2,3}"))
            //{
            //    Console.WriteLine("vaild");
            //}
            //else
            //{
            //    Console.WriteLine("invaild");
            //}

            //string a1 = "sri rama";
            //string a2 = Regex.Replace(a1, "\\s", "");
            //Console.WriteLine(a2);

            //            string a3 = "sri ram";
            //            Regex regex = new Regex(a3);
            //            String a4 = regex.Replace(a3, "jai sri rama");
            //            Console.WriteLine(a4);

            //            // string pattern = @"\b[m]\w+";
            //            // Regex regex = new Regex(pattern);
            //            // string author = "mahesh mahendra sri";
            //            //MatchCollection matchCollection=regex.Matches( author);
            //            // for (int count = 0; count < matchCollection.Count; count++)
            //            // {
            //            //     Console.WriteLine(count);
            //            // }
            //string d = @"^\b\w+";
            //string input = "allu arjun";
            //Regex regex1 = new Regex(input);
          if (Regex.IsMatch("allu arjun",@"^\b\w+"))
          
            {
                Console.WriteLine("vaild");
            }
            else
            {
                Console.WriteLine("i9nvail");
            }

            //            string pathnew= @"C:\FileProg\rama.txt";
            //            File.Create(pathnew);
            //            File.WriteAllText(pathnew, "jai sri ram");
            //            try
            //            {
            //                if (File.Exists(pathnew))
            //                {
            //                    File.OpenRead(pathnew);

            //                }
            //                else
            //                {
            //                    throw new IOException("no");
            //                }

            //            }catch (Exception ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
        }    }
}
