using System;
using System.Text;

namespace VariasString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ola \u058D";
            Console.WriteLine(s);

            string t = "C:\\Users\\Vitor\\Documents\\OneDrive";
            Console.WriteLine(t);

            Console.ReadKey();
        }
    }
}
