using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menor_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double n = 0;
            double maiorNumero = 0;
            List<double> numeros = new List<double>();
            for(i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite um numero");
                n = double.Parse(Console.ReadLine());
                numeros.Add(n);
            }

            double n1 = numeros[0];
            double n2 = numeros[1];
            double n3 = numeros[2];

            if(n1 > n2 && n1 > n3)
            {
                maiorNumero = n1;
            }
            else if(n2 > n1 && n2 > n3)
            {
                maiorNumero = n2;
            }
            else if(n3 > n1 && n3 > n2)
            {
                maiorNumero = n3;
            }

            Console.WriteLine("O maior número é " + maiorNumero);
            Console.ReadKey();
        }
    }
}
