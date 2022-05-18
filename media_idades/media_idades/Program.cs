using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_idades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a idade do primeiro aluno: ");
            int idade1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a idade do segundo aluno: ");
            int idade2 = int.Parse(Console.ReadLine());
            Console.Write("Digite a idade do terceiro aluno: ");
            int idade3 = int.Parse(Console.ReadLine());

            int media_idades = (idade1 + idade2 + idade3) / 3;

            Console.WriteLine("A média das idades dos alunos é de {0} anos.", media_idades.ToString("F2")); //Arredonda pra 2 casas decimais

            Console.ReadKey();
        }
    }
}
