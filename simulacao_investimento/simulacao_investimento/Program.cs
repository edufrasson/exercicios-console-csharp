using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacao_investimento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a cotacao do dólar: ");
            double cotacao_dolar = double.Parse(Console.ReadLine());

            Console.Write("Informe a cotacao do euro: ");
            double cotacao_euro = double.Parse(Console.ReadLine());

            Console.Write("Informe a cotacao do ouro: ");
            double cotacao_ouro = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor a ser investido: ");
            double valor_investido = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor em Dolar: {0}", (valor_investido / cotacao_dolar).ToString("f2"));
            Console.WriteLine("Valor em Euro: {0}", (valor_investido / cotacao_euro).ToString("f2"));
            Console.WriteLine("Valor em Ouro: {0}", (valor_investido / cotacao_ouro).ToString("f2"));

            Console.ReadKey();
        }
    }
}
