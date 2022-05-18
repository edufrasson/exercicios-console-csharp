using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estrutura_decisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você gosta de programação? ( S / N )");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "S")
                Console.WriteLine("SIM");
            if (resposta == "N")
                Console.WriteLine("NÃO");

            Console.ReadKey();
        }
    }
}
