using classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ::: COMPANY DETAILS ::: ");
            Console.Write("Enter the name of your company :");
            Class1.getCompanyName( Console.ReadLine());       
        }
    }
}