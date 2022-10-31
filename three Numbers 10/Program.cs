using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace three_Numbers_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st nm");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd nm");
            int n2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 3rd");
            int n3=Convert.ToInt32(Console.ReadLine());

            Console.Write("Results of the numbers : {0},{1},{2},(x+y).z is{3}and x.y+y.z is{4}\n\n" ,n1,n2,n3,((n1+n2)*n3),(n1*n2+n2*n3));
            Console.ReadLine();
        }
    }
}
