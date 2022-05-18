using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salario_liquido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Salário bruto: ");
            double salario_bruto = double.Parse(Console.ReadLine());

            Console.Write("Vale alimentação: ");
            double vale_alimentacao = double.Parse(Console.ReadLine());

            Console.Write("Numero de filhos: ");
            int num_filho = int.Parse(Console.ReadLine());

            Console.Write("Valor por filho: ");
            double valor_filho = double.Parse(Console.ReadLine());

            Console.Write("Numero de horas: ");
            int num_horas = int.Parse(Console.ReadLine());

            Console.Write("Valor por hora: ");
            double valor_horas = double.Parse(Console.ReadLine());

            Console.Write("Valor do INSS: ");
            double valor_inss = double.Parse(Console.ReadLine());

            Console.Write("Valor do IRPF: ");
            double valor_irpf = double.Parse(Console.ReadLine());

            double salario_liquido = salario_bruto + vale_alimentacao 
                + (num_filho * valor_filho) + (num_horas * valor_horas) - (valor_inss + valor_irpf);

            Console.WriteLine("Salário Líquido: {0}", salario_liquido.ToString("C"));

            // .ToString("C") formata mostrando as casas decimais
            // C -> Currency (moeda)

            Console.ReadKey();

        }
    }
}
