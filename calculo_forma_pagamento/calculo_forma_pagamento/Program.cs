using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_forma_pagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor da venda: ");
            double valor_venda = double.Parse(Console.ReadLine());

            Console.Write("Informe a forma de pagamento (DI, CA, CH): ");
            string forma_pagamento = Console.ReadLine().ToUpper();

            double valor_desconto, valor_final;

            if (forma_pagamento == "DI")
                valor_desconto = valor_venda * 0.1;
            else if (forma_pagamento == "CA")
                valor_desconto = valor_venda * 0.075;
            else if (forma_pagamento == "CH")
                valor_desconto = valor_venda * 0.05;
            else
            {
                Console.WriteLine("Digite uma forma de pagamento válida! Pressione qualquer tecla para sair");
                Console.ReadKey();
                return;
            }                

            valor_final = valor_venda - valor_desconto;

            Console.WriteLine("O valor do desconto será " + valor_desconto.ToString("C"));
            Console.WriteLine("O valor final da compra será " + valor_final.ToString("C"));

            Console.ReadKey();
        }
    }
}
