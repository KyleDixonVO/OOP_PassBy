using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PassBy
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pass By Value vs. Pass By Reference");
            Console.WriteLine("(related to passing perams to methods)");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");

            int a = 100;
            Console.WriteLine(a);
            Test(ref a);
            Console.WriteLine(a);

            //Test (ref a);







            Console.WriteLine("");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);
        }

        //static void test(ref int a)
        static void Test(ref int a)
        {
            a = 200;
        }

        //pass by ref - default for classes
        //pass by value - default for vars
    }
}
