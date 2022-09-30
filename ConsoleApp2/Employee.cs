using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp2
{
   public class Employee
    {
        public  delegate void promote(string g,int t);
        void getpromotion(string name, int sal)
        {
            Console.WriteLine("  the employee with name " + name + " is promoted to salary is " + sal);
        }
        public static void Main(string[] args)
        {
           
            Console.WriteLine(" enter the names of employees");
            string[] arr = new string[5];
            int i;
            for(i=0;i<5;i++)
            {
                arr[i] = Console.ReadLine();
            }
            Employee h = new Employee();
            promote uh;
            uh = h.getpromotion;
            uh.Invoke(arr[1],1268);
            uh.Invoke(arr[4], 1258);


        }
    }
}
