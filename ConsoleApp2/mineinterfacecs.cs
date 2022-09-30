using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface ivehicle
    {
        public    void drive();
        public  bool refuel(int ho);
    }
    public class Car :ivehicle
    {
      public   int startamountofcar;
        public Car(int startamountofcar)
        {
            this.startamountofcar = startamountofcar;
        }
        public  void drive()
        {
            if (startamountofcar > 0)
            {
                Console.WriteLine("    the person is driving ro");
            }
            else
            {
                Console.WriteLine(" the person is not going eldo");
            }
        }
        public  bool refuel(int ho)
        {
            startamountofcar = startamountofcar + ho;
            return true;
        }
    }
    public class mineinterfaces
    {
        public static void Main(string[] args)
        {
            Car o = new Car(0);
            int j = Convert.ToInt32(Console.ReadLine());
            o.drive();
            Console.WriteLine(o.refuel(j));
            Console.WriteLine(" finalfuelis" +o.startamountofcar);
        }
    }
}
