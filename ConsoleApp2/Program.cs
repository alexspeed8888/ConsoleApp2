using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 5;
            int i2 = 6;
            double d1 = 2.57;
            double suma = i1 + d1;
            Console.WriteLine("Hello World!");
            string valor = Console.ReadLine();
            Console.WriteLine("El número introducido es: "+valor);
            int valorInt = Convert.ToInt32(valor);
            Console.ReadKey();
        }
    }
}
