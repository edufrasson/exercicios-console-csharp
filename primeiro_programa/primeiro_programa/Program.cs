using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro_programa
{
    internal class Program
    {
        // Funções
        public static int Somar(int numero, int numero2)
        {
            return numero + numero2;
        }

        public static void Mostrar_Nome(string nome)
        {
            Console.WriteLine("Olá {0}!", nome);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Atributos do Console
            Console.BackgroundColor = ConsoleColor.Black; // Fundo da tela

            Console.ForegroundColor = ConsoleColor.Green; // Cor da fonte

            Console.Title = "Meu primeiro programa em C#"; // Titulo da janela 

            // Declaração de varíavel
            bool numero_bool = false;
            int i = 0;            
            string nome = "Eduardo";
            int numero = 5;
            int numero2 = 4;

            Console.WriteLine(2);
            Console.WriteLine("2");
            Console.WriteLine(2+2);
            Console.WriteLine("2" + "2");
            Console.WriteLine(2.5);
            Console.ReadKey();

            // Limpa tela
            Console.Clear();

            // Estrutura de Decisão
            if(numero_bool == false)
            {
                Console.WriteLine("A");
            }

            //Repetição While
            while (i < 5)
            {
                Console.WriteLine("oi");
                i++;
            }

            // Repetição For 
            for(i = 0; i < 5; i++)
            {
                Console.WriteLine("tchau");
            }

            // Void = funçao sem return
            Mostrar_Nome(nome);

            // Funçao com return
            int soma = Somar(numero, numero2);
            Console.WriteLine(soma);

            // Try catch 
            try
            {
                if (numero_bool == false)
                {
                    throw new Exception();
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Emite um som
            Console.Beep();    

            // Pausa a execução
            Console.ReadKey();
        }
    }
}
