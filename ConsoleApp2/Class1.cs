using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class phonebook
    {

    }
    public class service : phonebook
    {
        public void yoht(List<Tuple<string, int, string, int>> profesionals)
        {
            int i;
            Console.WriteLine(" the service are ");
            for (i =0;i< profesionals.Count; i++)
            {
                Console.WriteLine(profesionals[i].Item1 + " " + profesionals[i].Item2 + " " + profesionals[i].Item3 + " " + profesionals[i].Item4);
            }
        }

    }
    public class student : phonebook
    {
        public void details(List<Tuple<string, int,int>> students)
        {
            int i;
            Console.WriteLine(" the student are");
            for (i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].Item1 + " " + students[i].Item2 + " " + students[i].Item3 );
            }
        }

    }
    public class citesens : phonebook
    {
        public void data(List<Tuple<string, int, int>> students)
        {
            int i;
            Console.WriteLine(" the citesen are..");
            for (i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].Item1 + " " + students[i].Item2 + " " + students[i].Item3);
            }
        }

    }
    public class Class1
    {
        public static void Main(string[] args)
        {
            int i;
            var list = new List<Tuple<string, int, string, int>>();
            var ogy = new List<Tuple<string, int, int>>();
            var jyt = new List<Tuple<string, int, int>>();
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine(" enter the name");
                string o = Console.ReadLine();
                Console.WriteLine(" enter the age");
                int h = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" enter the profession  ");
                string j = Console.ReadLine();
                Console.WriteLine(" enter the phone number  ");
                int t = Convert.ToInt32(Console.ReadLine());
               
                if (j !="")
                {


                    list.Add(new Tuple<string, int, string, int>(o, h, j, t));




                }
                else
                {
                    if (h < 18)
                    {

                        ogy.Add(new Tuple<string, int, int>(o, h, t));

                    }
                    else
                    {

                        jyt.Add(new Tuple<string, int, int>(o, h, t));

                    }
                }
            }
            service ji = new service();
            
            ji.yoht(list);
            student pg = new student();
            
            pg.details(ogy);
            citesens hi = new citesens();
           
            hi.data(jyt);
        }
    }
}
