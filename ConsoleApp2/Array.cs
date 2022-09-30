using System;
namespace ConsoleApp2
{
    public class Array
    {
        public static void Main(string[] args)
        {
            int j = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[j];
            int i;
            Console.WriteLine(" enter the array values");
            for(i=0;i<j;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            int t = arr[0];
            int o = arr[0];
            for(i=0;i<j;i++)
            {
                if (arr[i]<t)
                {
                    t= arr[i];
                }
                if (arr[i]>o)
                {
                    o = arr[i];
                }
            }
            Console.WriteLine(" the minimum value is " + t);
            Console.WriteLine(" the maximumvalue is " + o);        }


    }
}