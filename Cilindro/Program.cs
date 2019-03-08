using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            string heigthValue;
            string radiusValue;
            float heigthValues;
            float radiusValues;
            float pi = 3.1415926F;
            float volume;
            float area;

            //introduçao ao programa do cilindro//
            Console.WriteLine("welcome to GeoBuild!\n");

            //pede valor de altura//
            Console.WriteLine("insert your heigth value:\t");
            heigthValue = Console.ReadLine();
            //converte altura em float//
            heigthValues = Convert.ToSingle(heigthValue);

            //pede valor de raio//
            Console.WriteLine("insert your radius value:\t");
            radiusValue = Console.ReadLine();
            //converte raio em float//
            radiusValues = Convert.ToSingle(radiusValue);

            //calcular volume//
            volume = pi * radiusValues * radiusValues * heigthValues;
            Console.WriteLine($"your cilinder equals to\t {volume:f3}");

            //calcular área superficial//
            area = 2 * pi * radiusValues * (radiusValues + heigthValues);
            Console.WriteLine("your superficial area equals to\t {0:f3}", area);

        }
    }
}
