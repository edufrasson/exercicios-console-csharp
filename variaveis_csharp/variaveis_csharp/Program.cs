using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variaveis_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplo 1 
            /*string nome, curso, cidade;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu curso: ");
            curso = Console.ReadLine();

            Console.WriteLine("Digite sua cidade: ");
            cidade = Console.ReadLine();

            Console.WriteLine("O nome digitado foi: {0} \nO curso digitado foi: {1} \nA cidade digitada foi: {2}", nome, curso, cidade);
            
            Console.ReadKey();

            */

            /*
            string modelo, marca, cor;

            Console.WriteLine("Digite o modelo do veículo: ");
            modelo = Console.ReadLine();

            Console.WriteLine("Digite a marca do veículo: ");
            marca = Console.ReadLine(); 

            Console.WriteLine("Digite a cor do veículo: ");
            cor = Console.ReadLine();

            Console.WriteLine("Digite o ano do veículo: ");
            int ano = int.Parse(Console.ReadLine());   

            Console.WriteLine("Digite a quilometragem do veículo: ");
            int quilometragem = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Modelo do veículo: " + modelo);
            Console.WriteLine("Marca do veiculo: " + marca);
            Console.WriteLine("Cor do veículo: " + cor);
            Console.WriteLine("Ano do veiculo: " + ano);
            Console.WriteLine("Quilometragem do veiculo: " + quilometragem + " km");

            Console.ReadKey();*/

            Console.WriteLine("Digite o primeiro numero: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            double n2 = double.Parse(Console.ReadLine());

            double resultado = n1 + n2;

            Console.WriteLine("O resultado da soma é " + resultado);

            Console.ReadKey();
        }
    }
}
