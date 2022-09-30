using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class jioy
    {
        public static void Main(string[] args)
        {
            StreamReader jt = new StreamReader("C:\\Users\\saijyothi.bheri\\numberofhe.txt");
            StreamWriter ho = new StreamWriter("C:\\Users\\saijyothi.bheri\\g1.txt");
            string o = "";
            while ((o = jt.ReadLine()) != null)
            {
                for (int i = 0; i < o.Length; i++)
                {
                    if (o[i].Equals('a'))
                    {

                        ho.Write("1");
                       

                    }
                    else if (o[i].Equals('e'))
                    {
                        ho.Write("2");
                    }
                    else if (o[i].Equals('i'))
                    {
                        ho.Write("3");
                    }
                    else if (o[i].Equals('o'))
                    {
                        ho.Write("4");
                        
                    }
                    else if (o[i].Equals('u'))
                    {
                        ho.Write("5");
                    }
                    else
                    {
                        ho.Write(o[i]);
                    }
                }
                ho.WriteLine();
            }
            ho.Close();
            jt.Close();

            StreamReader ji = new StreamReader("C:\\Users\\saijyothi.bheri\\g1.txt");
            string jo = "";
            while((jo=ji.ReadLine()) != null)
            {
                int i;
                for(i=0;i<jo.Length;i++)
                {
                    if(jo[i].Equals('1'))
                    {
                        Console.Write('a');
                    }
                    else if (jo[i].Equals('2'))
                    {
                        Console.Write('e');
                    }
                    else if (jo[i].Equals('3'))
                    {
                        Console.Write('i');
                    }
                    else if (jo[i].Equals('4'))
                    {
                        Console.Write('o');
                    }
                    else if (jo[i].Equals('5'))
                    {
                        Console.Write('u');
                    }
                    else
                    {
                        Console.Write(jo[i]);
                    }
                }
                Console.WriteLine();

            }
            
        }
    }
}
