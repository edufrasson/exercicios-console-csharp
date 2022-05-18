using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idade_em_dias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe sua idade em anos: ");
            int idade_em_anos = int.Parse(Console.ReadLine());

            Console.Write("Informe sua idade em meses: ");
            int idade_em_meses = int.Parse(Console.ReadLine());

            Console.Write("Informe sua idade em dias: ");
            int idade_em_dias = int.Parse(Console.ReadLine());

            int total_idade_em_dias = (idade_em_anos * 365) + (idade_em_meses * 30) + idade_em_dias;

            Console.WriteLine("A pessoa viveu um total de {0} dias.", total_idade_em_dias);

            Console.ReadKey();
        }
    }
}
