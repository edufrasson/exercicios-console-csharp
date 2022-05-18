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
            string continuar = "S";
            int opcao = 0;
            int i = 0;
            double salario = 0;
            double salario_total = 0;
            double salario_bruto,descontos, comissao, vendas, valor_hora, horas;

            while(continuar == "S")
            {
                Console.WriteLine("Escolha a forma de contratação do funcionário\n" +
                    "0 - Assalariado\n1 - Comissionado\n2 - Horista");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Digite o valor do salário");
                        salario_bruto = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o valor dos descontos:");
                        descontos = double.Parse(Console.ReadLine());

                        salario = salario_bruto - descontos;                     
                        break;

                    case 1:
                        Console.WriteLine("Digite o percentual da comissao");
                        comissao = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o valor de vendas:");
                        vendas = double.Parse(Console.ReadLine());

                        salario = vendas * (comissao / 100);                       
                        break;

                    case 2:
                        Console.WriteLine("Digite o valor da hora");
                        valor_hora = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o valor dos descontos:");
                        horas = double.Parse(Console.ReadLine());

                        salario = valor_hora * horas;                       
                        break;                       
                }

                salario_total += salario;
                i++;
                Console.WriteLine("Deseja adicionar mais um funcionário? S / N");
                continuar = Console.ReadLine().ToUpper();
            }

            Console.WriteLine("Folha de pagamento: " + salario_total);
            Console.WriteLine("Quantidade de funcionarios: " + i);
            Console.WriteLine("Média Salarial: " + (salario_total / i));
            Console.ReadKey();
        }
    }
}
