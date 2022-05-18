using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celsius_fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;
            int op;
            string continuar;
            while (true) 
            { 
                Console.WriteLine("Digite uma opção");
                Console.WriteLine("1- Celsius para Fahrenheit");
                Console.WriteLine("2- Fahrenheit para Celsius");
                op = int.Parse(Console.ReadLine());

                switch(op)
                {
                    case 1:
                        Console.Write("Digite o valor em celsius: ");
                        celsius = double.Parse(Console.ReadLine());

                        fahrenheit = (celsius * 1.8) + 32;
                        Console.WriteLine("O valor {0}°C equivale a {1}°F", celsius, fahrenheit);
                   break;

                   case 2:
                        Console.Write("Digite o valor em fahrenheit: ");
                        fahrenheit = double.Parse(Console.ReadLine());

                        celsius = (fahrenheit - 32) / 1.8;
                        Console.WriteLine("O valor {0}°F equivale a {1}°C", fahrenheit, celsius.ToString("F2"));
                   break;

                   default:
                        Console.WriteLine("Selecione uma opção válida!");
                   break; 
                }

                Console.WriteLine("Deseja realizar outra conversão? (S / N)");
                continuar = Console.ReadLine().ToUpper();
                if(continuar == "N")
                {
                    break;
                }


                /*Console.ReadKey();*/
            }
        }
    }
}
