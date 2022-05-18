using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211082_211081
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis

            double despesa_agua, despesa_aluguel, despesa_energia, despesa_internet, despesa_salario_fixo, despesa_comissao, outros_gastos;
            double valor_por_peca, valor_comissao, total_despesas, total_receitas, valor_final;
            int quantidade_peca;

            // Entrada das Despesas
            Console.WriteLine("=======================\n" +
                                "Entrada das despesas\n" +
                              "=======================");

            Console.Write("Aluguel: R$");
            despesa_aluguel = double.Parse(Console.ReadLine());

            Console.Write("Agua: R$");
            despesa_agua = double.Parse(Console.ReadLine());

            Console.Write("Energia Elétrica: R$");
            despesa_energia = double.Parse(Console.ReadLine());

            Console.Write("Internet: R$");
            despesa_internet = double.Parse(Console.ReadLine());

            Console.Write("Salário Fixo dos funcionários: R$");
            despesa_salario_fixo = double.Parse(Console.ReadLine());

            Console.Write("Valor da comissao por peça: R$");
            valor_comissao = double.Parse(Console.ReadLine());

            Console.Write("Outros gastos: R$");
            outros_gastos = double.Parse(Console.ReadLine());

            Console.WriteLine("=======================\n" +
                                "Entrada das receitas\n" +
                              "=======================");

            Console.Write("Quantidade de peças vendidas:");
            quantidade_peca = int.Parse(Console.ReadLine());

            Console.Write("Valor por peça vendida: R$");
            valor_por_peca = double.Parse(Console.ReadLine());

            // Processamento

            despesa_comissao = valor_comissao * quantidade_peca;

            total_despesas = despesa_agua + despesa_aluguel + despesa_energia + despesa_internet + despesa_comissao + despesa_salario_fixo + outros_gastos;

            total_receitas = valor_por_peca * quantidade_peca;

            valor_final = total_receitas - total_despesas;

            // Saídas

            Console.WriteLine("=======================\n" +
                                    "Saídas\n" +
                              "=======================");

            Console.WriteLine("Valor total das despesas: R$" + total_despesas);
            Console.WriteLine("Valor total das receitas: R$" + total_receitas);
            Console.WriteLine("Valor final do exercício da empresa: R$" + valor_final);
            Console.ReadKey();
        }
    }
}
