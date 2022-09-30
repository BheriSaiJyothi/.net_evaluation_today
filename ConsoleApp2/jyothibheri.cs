using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
    public  class jyothibheri
    {
        public static  void jyo_cheifguset_one()
        {
            Console.WriteLine(" the cheif guest arrived  jyo");
        }
        public static  void decorations()
        {
            Console.WriteLine(" the decorations are yes jyo");
        }
        public static  void gift_jyo()
        {
            Console.WriteLine(" the gifts jyo");
        }
        public static  void caterein()
        {
            Console.WriteLine(" the jyo  ");
        }
        public static void Main(string[] args)
        {
            jyothibheri i = new jyothibheri();
            Thread thread1 = new Thread(new ThreadStart(jyo_cheifguset_one));
            Thread thread2 = new Thread(new ThreadStart(decorations));
            Thread thread49 = new Thread(new ThreadStart(gift_jyo));
            Thread thread28 = new Thread(new ThreadStart(caterein));

            thread1.Priority = ThreadPriority.Highest;
            thread2.Priority = ThreadPriority.AboveNormal;
            thread49.Priority = ThreadPriority.Lowest;
            thread28.Priority = ThreadPriority.BelowNormal; 
            thread1.Start();
            thread2.Start();
           
            thread49.Start();
            thread28.Start();
        }
    }
}
