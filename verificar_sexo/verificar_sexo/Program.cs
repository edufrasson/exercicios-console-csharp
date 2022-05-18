using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificar_sexo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe o sexo do usuário (M / F): ");
            string sexo = Console.ReadLine().ToUpper();

            if (sexo == "M")
                Console.WriteLine("O usuário é do sexo Masculino");

            if (sexo == "F")
                Console.WriteLine("O usuário é do sexo Feminino");
            else
                Console.WriteLine("Informe um valor válido");

            Console.ReadKey();
        }
    }
}
