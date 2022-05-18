using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salario_vendedor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o salario fixo: ");
            double salario_fixo = double.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de peças vendidas: ");
            double qnt_vendida = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor da comissao por peça: ");
            double valor_comissao = double.Parse(Console.ReadLine());

            Console.Write("Informe a kilometragem: ");
            double km = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor por km percorrido: ");
            double valor_km = double.Parse(Console.ReadLine());

            double salario_final = salario_fixo + (qnt_vendida * valor_comissao) + (km * valor_km);

            Console.Write("Valor do salário final: {0}", salario_final.ToString("C"));

            Console.ReadKey();
        }
    }
}
