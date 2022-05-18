using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_operacoes
{
    internal class Program
    {       
   
        static void Main(string[] args)
        {
            double resultado;

            Console.Write("Digite o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Resultados: ");

            resultado = n1 + n2;
            Console.WriteLine("{0} + {1} = {2} ", n1, n2, resultado);

            resultado = n1 - n2;
            Console.WriteLine("{0} - {1} = {2} ", n1, n2, resultado);

            resultado = n1 / n2;
            Console.WriteLine("{0} / {1} = {2} ", n1, n2, resultado);

            resultado = n1 * n2;
            Console.WriteLine("{0} * {1} = {2} ", n1, n2, resultado);

            Console.ReadKey();
        }
    }
}
