using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethodTypes
{
    internal class Program
    {

        static int Print(int a)
        {
            return a;
        }

        static string Print(string s)
        {
            return s;
        }

        //do same thing with generic type

        static T PrintF<T>(T m)
        {
            return m;
        }


        //with multiple parameters 
        static void PrintFC<T,U>(T p,U q,U w)
        {
            Console.WriteLine($"{p},{q},{w}");
        }
        static void Main(string[] args)
        {

            int r= Print(10);
            Console.WriteLine(r);

            string r1 = Print("aadil");
            Console.WriteLine(r1);

            // the type get check at run time
            Console.WriteLine(PrintF("C"));
            Console.WriteLine(PrintF(10));
            Console.WriteLine(PrintF(10.5));


            PrintFC("aadil", 1,1);

        }
    }
}
