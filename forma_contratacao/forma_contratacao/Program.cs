using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forma_contratacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escolha o tipo de contratacao: ");

            Console.WriteLine("1 - Assalariado \n 2 - Comissionado \n 3 - Horista");
            int opcao = int.Parse(Console.ReadLine());
            double salario = 0;
            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o valor do salario: ");
                    double salario_bruto = double.Parse(Console.ReadLine());

                    Console.Write("Digite o valor da porcentagem de imposto: ");
                    double imposto = double.Parse(Console.ReadLine());

                     salario = salario_bruto - (salario_bruto * (imposto / 100));
                    break;

                case 2:
                    Console.Write("Digite o valor da venda: ");
                    double valor_venda = double.Parse(Console.ReadLine());

                    Console.Write("Digite o valor da porcentagem de comissão: ");
                    double comissao = double.Parse(Console.ReadLine());

                    salario = valor_venda * (comissao / 100);
                    break;

                case 3:
                    Console.Write("Digite a quantidade de horas trabalhadas: ");
                    double horas = double.Parse(Console.ReadLine());

                    Console.Write("Digite o valor das horas trabalhadas: ");
                    double valor_horas = double.Parse(Console.ReadLine());

                    salario = horas * valor_horas;
                    break;

                default:
                    Console.WriteLine("Digite um valor válido.");
                    break;
            }

            Console.WriteLine("O salário é: " + salario);
            Console.ReadKey();
        }
    }
}
