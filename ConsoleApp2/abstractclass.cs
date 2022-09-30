using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public  abstract class bird
    {
        public string name;
        public void setname(string myname)
        {
            name = myname;
        }
        public string getname()
        {
            return name;
        }
        public virtual void fly()
        {
            Console.WriteLine(" the object fly  now");
        }
        public abstract void eat(); 
    }
    public class crow : bird
    {
        public  override void fly()
        {
            Console.WriteLine(" the crow is flying in sky");
        }
        public override void eat()
        {
            Console.WriteLine(" the crow is eating");
        }

    }
    public class parrot : bird
    {
        public override void fly()
        {
            Console.WriteLine(" the parrot is flying in sky");
        }
        public override void eat()
        {
            Console.WriteLine(" the parrot is eating");
        }

    }
    public class abstractclass
    {
        public  static void Main(string[] args)
        {
            crow ho = new crow();
            Console.WriteLine(" enter the name of crow");
            string name = Console.ReadLine();
            ho.setname(name);
            Console.WriteLine(" the name of crow is " +ho.getname());
           ho.fly();
            ho.eat();

            parrot ht = new parrot();
            Console.WriteLine(" enter the name of parrot now");
            string parrotname = Console.ReadLine();
            ht.setname(parrotname);
            Console.WriteLine(" the name of parrot is " + ht.getname());
            ht.fly();
            ht.eat();


        }
    }
}
