using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class classfile
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" enter the name of file");
            string file;
            file = Console.ReadLine();
            FileStream go = new FileStream("C:\\Users\\saijyothi.bheri\\" + file, FileMode.Create);
            go.Close();
            StreamWriter ho = new StreamWriter("C:\\Users\\saijyothi.bheri\\" + file);
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(" enter the data");
                string jo = Console.ReadLine();
                ho.WriteLine(jo);
            }
            string get_oldword = Console.ReadLine();
            string get_newword = Console.ReadLine();
            string r;
            ho.Close();
            
            String strFile = File.ReadAllText("C:\\Users\\saijyothi.bheri\\" + file);

            strFile = strFile.Replace(get_oldword, get_newword);

            File.WriteAllText("C:\\Users\\saijyothi.bheri\\" + file, strFile);
            StreamReader ko = new StreamReader("C:\\Users\\saijyothi.bheri\\" + file);
            while ((r = ko.ReadLine()) != null)
            {
                Console.WriteLine(r);
            }
            ko.Close();
        }
    }
}
