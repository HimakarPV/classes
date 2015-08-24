using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Class1
    {

        public static void employeeDetails()
        {
            employee e = new employee();
            e.name = "Himakar";
            e.dob = "09-10-1993";
            e.city = "Bangalore";
            string EmployeeCode = "AZ016";

            Console.WriteLine("Enter your employee code : ");
            string x = Console.ReadLine().ToUpper();
            if (EmployeeCode == x)
            {
                Console.WriteLine("\nEMPLOYEE DETAILS \n");
                Console.WriteLine("NAME : {0} \nDOB : {1} \nLOCATON : {2} ",
                                    e.name, e.dob, e.city);


                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You entered the wrong code..");
                Console.ReadLine();
            }

        }

        public static void getCompanyName(string name)
        {
            if(name.ToUpper()== "AEZION")

            {
                Class1.employeeDetails();
            }
            else
            {
                Console.WriteLine("Enter correct company name..");
                Console.ReadLine();
            }
        }
        
    }
    public class employee
    {
        public string name { get; set; }
        public string dob { get; set; }
        public string city { get; set; }

    }
   
}
