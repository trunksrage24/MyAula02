using System;
using System.Text;

namespace VariasString
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            //EX01//
            string s = "ola \u058D";
            Console.WriteLine(s);

            string t = "C:\\Users\\Vitor\\Documents\\OneDrive";
            Console.WriteLine(t);

            //EX02//
            string r = "batata\t" + "mó" + "!!!";
            r += "\tbem bom";
            Console.WriteLine(r);

            int x = 34;
            int y = 35;
            string i = $"{x} mais {y} é igual a {x + y}";
            Console.WriteLine(i);

            string n = string.Format("batata mó!!! é igual a {0}", x+y);
            Console.WriteLine(n);

            //EX03//
            double xx = 0.12345;
            int ii = 18;
            string g = $"xx={xx:f2}";
            Console.WriteLine(g);

            string s1 = String.Format("{0:p1}", xx);
            Console.WriteLine(s1);

            Console.WriteLine("{0:x}", ii);
            Console.WriteLine("{0:c}", ii);


            Console.ReadKey();
        }
    }
}
