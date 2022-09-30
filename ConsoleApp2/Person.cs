using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Person
    {
        public static void Main(string[] args)
        {

            string name_person;
            int age;
            void toString(Queue<string> names, Queue<int> ages)
            {
                int i;
                for (i = 0; i < 5; i++)
                {
                    Console.WriteLine("name " + names.Dequeue() + ", age" + ages.Dequeue());
                }
            }
            Queue<string> names = new Queue<string>();
            Queue<int> ages = new Queue<int>();
           
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("enter the name of person");
                name_person= Console.ReadLine();
                Console.WriteLine(" enter the age of person");
                age = Convert.ToInt32(Console.ReadLine());
              
                names.Enqueue(name_person);
                ages.Enqueue(age);
                
            }
          
            toString(names, ages);


        }
    }
}
