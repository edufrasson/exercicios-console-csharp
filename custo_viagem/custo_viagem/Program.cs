using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custo_viagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do combustível: ");
            double valor_combustivel = double.Parse(Console.ReadLine());

            Console.Write("Digite a distância percorrida em quilometros: ");
            double distancia_percorrida = double.Parse(Console.ReadLine());

            Console.Write("Digite quantos km o veículo faz por litro: ");
            double km_por_litro = double.Parse(Console.ReadLine());

            double total_litro_gasto = distancia_percorrida / km_por_litro; 

            double total_gasto_viagem = total_litro_gasto * valor_combustivel;

            Console.WriteLine("Foi gasto R${0} para efetuar essa viagem.", total_gasto_viagem);

            Console.ReadKey();
        }
    }
}
