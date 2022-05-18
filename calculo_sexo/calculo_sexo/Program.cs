using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_sexo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            string sexo;
            int masc = 0; 
            int fem = 0;

            for(int i = 1; i < 5; i++)
            {
                Console.WriteLine("Informe o sexo da {0}º pessoa", i);
                sexo = Console.ReadLine().ToUpper();
                list.Add(sexo);
            }

            foreach(string valor_sexo in list)
            {
                if (valor_sexo == "M")                
                    masc++;

                if (valor_sexo == "F")
                    fem++;
            }

            Console.WriteLine("Total de homens: " + masc);
            Console.WriteLine("Total de mulheres: " + fem);

            Console.ReadKey();
        }
    }
}
