using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_gastos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double transporte, xerox, cantina, apm;

            Console.WriteLine("Qual o total mensal gasto com transporte? ");
            transporte = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o total mensal gasto com xerox? ");
            xerox = double.Parse(Console.ReadLine());   

            Console.WriteLine("Qual o total mensal gasto com a cantina? ");
            cantina = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o total gasto com a apm? ");
            apm = double.Parse(Console.ReadLine()); 

            double total_gasto = transporte + xerox + cantina + apm;

            Console.Clear();

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("   O total gasto no mês é R$" + total_gasto);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.ReadKey();
        }
    }
}
