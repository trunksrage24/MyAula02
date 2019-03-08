using System;
using System.Text;

namespace VariasString
{
    class Program
    {
        static void Main(string[] args)
        {
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


            Console.ReadKey();
        }
    }
}
