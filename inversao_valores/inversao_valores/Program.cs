using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inversao_valores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de b: ");
            int b = int.Parse(Console.ReadLine());

            int valor_b = b;
            int valor_a = a;

            b = valor_a;
            a = valor_b;

            Console.WriteLine("valor de a: " + a);
            Console.WriteLine("valor de b: " + b);

            Console.ReadKey();
        }
    }
}
