using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desconto_com_condicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor_total, valor_desconto;

            Console.Write("Digite a quantidade comprada: ");
            int quantidade_comprada = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor unitário: ");
            double valor_unitario = double.Parse(Console.ReadLine());

            valor_total = quantidade_comprada * valor_unitario;

            if (quantidade_comprada > 100)
            {
                Console.Write("Digite o % de desconto: ");
                double porcentagem_desconto = double.Parse(Console.ReadLine());

                valor_desconto = valor_total * (porcentagem_desconto / 100);
                valor_total = valor_total - valor_desconto;
            }
           
            Console.Write("O valor total da compra é: " + valor_total.ToString("C"));

            Console.ReadKey();
        }
    }
}
