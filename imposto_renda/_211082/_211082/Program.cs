using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211082
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua renda anual: R$");
            double renda = double.Parse(Console.ReadLine());

            if (renda <= 50000)
            {
                Console.WriteLine("ISENTO DE IMPOSTO");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Escolha a forma de calcular o imposto: ");
            Console.WriteLine("1 - SIMPLIFICADA \n2 - COMPLETA");
            int opcao = int.Parse(Console.ReadLine());
            double imposto_renda = 0;
            double gastos;
            switch (opcao)
            {
                case 1:
                    imposto_renda = renda * 0.15;
                    break;

                case 2:
                    Console.Write("Digite os seus gastos com estudo e saúde: ");
                    gastos = double.Parse(Console.ReadLine());

                    if (gastos > 10000)
                        gastos = 10000;

                    imposto_renda = (renda - gastos) * 0.2;
                    break;

                default:
                    Console.Write("Digite uma opção válida!");
                    Console.ReadKey();
                    return;
            }

            Console.WriteLine("O valor de imposto de renda para ser pago é: " + imposto_renda.ToString("C"));
            Console.ReadKey();
        }
    }
}
