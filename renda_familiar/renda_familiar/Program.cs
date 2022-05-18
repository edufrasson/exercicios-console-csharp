using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace renda_familiar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a renda familiar: ");
            double valor_renda = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor gasto com alimentação: ");
            double gasto_alimentacao = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor gasto com farmácia: ");
            double gasto_farmacia = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor gasto com vestuário: ");
            double gasto_vestuario = double.Parse(Console.ReadLine());

            Console.Write("Informe os outros gastos: ");
            double outros_gastos = double.Parse(Console.ReadLine());

            double total = valor_renda - (gasto_alimentacao + gasto_farmacia + gasto_vestuario + outros_gastos);

            if (total < 0)
            {
                Console.WriteLine("Infelizmente a renda não foi suficiente, faltaram: " + Math.Abs(total).ToString("C"));
            }
            else
            {
                Console.WriteLine("Ufa, esse mês a renda foi suficiente, sobraram: " + total.ToString("C"));
            }

            Console.ReadKey();
        }
    }
}
