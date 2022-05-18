using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raio_circunferencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o Raio do círculo: ");
            double raio = double.Parse(Console.ReadLine());

            double area = Math.PI * (raio * raio);
            double diametro = 2 * raio;
            double perimetro = 2 * Math.PI * raio;

            Console.WriteLine("A área do circulo é: " + area.ToString("f2"));
            Console.WriteLine("O diâmetro do circulo é: " + diametro.ToString("f2"));
            Console.WriteLine("O perímetro do circulo é: " + perimetro.ToString("f2"));

            Console.ReadKey();
        }
    }
}
