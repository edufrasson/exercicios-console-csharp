using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_formas
{
    internal class Program
    {
        static double calcularAreaQuadrado()
        {
            Console.Write("Digite o valor do lado do quadrado: ");
            double valor_lado = double.Parse(Console.ReadLine());

            double area_quadrado = Math.Pow(valor_lado, 2);

            return area_quadrado;
        }

        static double calcularAreaRetangulo()
        {
            Console.Write("Digite o valor da base do retangulo: ");
            double valor_base = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da altura do retangulo: ");
            double valor_altura = double.Parse(Console.ReadLine());

            double area_retangulo = valor_altura * valor_base;
            return area_retangulo;
        }

        static double calcularAreaTrapezio()
        {
            Console.Write("Digite o valor da base menor do trapézio: ");
            double base_menor = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da base maior do trapézio: ");
            double base_maior = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da altura do trapézio: ");
            double altura = double.Parse(Console.ReadLine());

            double area_trapezio = ((base_maior + base_menor) * altura) / 2;

            return area_trapezio;
        }

        static double calcularAreaLosango()
        {
            Console.Write("Digite o valor da diagonal menor do losango: ");
            double diagonal_menor = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da diagonal maior do losango: ");
            double diagonal_maior = double.Parse(Console.ReadLine());

            double area_trapezio = (diagonal_maior * diagonal_menor) / 2;

            return area_trapezio;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("================================");
                Console.WriteLine("Escolha uma forma geométrica: ");
                Console.WriteLine("1 - Quadrado \n" +
                                  "2 - Retângulo \n" +
                                  "3 - Trapézio \n" +
                                  "4 - Losango"
                    );
                Console.WriteLine("================================");

                int opcao = int.Parse(Console.ReadLine());
                double area = 0;
                switch (opcao)
                {
                    case 1:
                        area = calcularAreaQuadrado();
                        break;

                    case 2:
                        area = calcularAreaRetangulo();
                        break;

                    case 3:
                        area = calcularAreaTrapezio();
                        break;

                    case 4:
                        area = calcularAreaLosango();
                        break;

                    default:
                        Console.WriteLine("Digite uma opção válida");
                        break;
                }

                Console.WriteLine("O valor da área é: " + area);               
            }
            
        }
    }
}
