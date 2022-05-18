using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211082
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ano de nascimento do funcionário: ");
            int ano_nascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano que ele entrou na empresa: ");
            int ano_empresa = int.Parse(Console.ReadLine());

            int idade = 2022 - ano_nascimento;
            int tempo_empresa = 2022 - ano_empresa;

            if (idade >= 65 || tempo_empresa >= 30 || idade >= 60 && tempo_empresa >= 25)
                Console.WriteLine("Requerer Aposentadoria");
            else
                Console.WriteLine("Não requerer");

            Console.ReadKey();
        }
    }
}
