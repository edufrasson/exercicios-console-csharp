using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a conta: ");
            string conta = Console.ReadLine();

            string[] linha = conta.Split(' ');

            int n1 = int.Parse(linha[0]);
            int n2 = int.Parse(linha[2]);
            string operacao = linha[1];
            double resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = n1 + n2;
                break;

                case "-":
                    resultado = n1 - n2;
                break;

                case "*":
                    resultado = n1 * n2;
                break;

                case "/":
                    resultado = n1 / n2;
                break;

                default:
                    Console.WriteLine("Digite uma operação válida! pressione uma tecla para sair");
                    Console.ReadKey();
                    return;
            }

            Console.WriteLine("O resultado da conta é " + resultado);

            Console.ReadKey();
        }
    }
}
