using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tres_produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = 0, total = 0;
            int qtde = 0;


            Console.WriteLine("Digite a quantidade");
            qtde = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto");
            valor = double.Parse(Console.ReadLine()); 
            
            total += valor * qtde;

            Console.WriteLine("Digite a quantidade");
            qtde = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto");
            valor = double.Parse(Console.ReadLine());
          
            total += valor * qtde;

            Console.WriteLine("Digite a quantidade");
            qtde = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto");
            valor = double.Parse(Console.ReadLine());
            
            total += valor * qtde;


            Console.WriteLine(total);
            Console.ReadKey();

        }
    }
}
