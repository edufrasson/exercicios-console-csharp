using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estrutura_repeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Pares \n2 - Ímpares");
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("========================");

            int i = 0;

            while (i <= 100)
            {
                switch (opcao)
                {
                    case 1:
                        if (i % 2 == 0)
                            Console.WriteLine(i);
                        i++;
                        break;

                    case 2:
                        if (i % 2 != 0)
                            Console.WriteLine(i);
                        i++;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        Console.ReadKey();
                        return;
                }
               
            }

            Console.ReadKey();
                
        }
    }
}
