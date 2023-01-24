using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 1;

            do
            {
                Console.Clear();
                menu();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\n\tOpção pretendida: ");
                Console.ForegroundColor = ConsoleColor.White;
                opcao = Convert.ToInt32(Console.ReadLine());
            } while (opcao != 0);
        }
    }

    static void menu()
    {
        Console.Clear();
            Console.Write("\n\n\t********** Exercícios com Vetores ************");
            Console.Write("\n\n\t 1 - Inicialização de Vetor / Posição");
            Console.Write("\n\n\t 2 - Visualização do Valor na Posição X");
            Console.Write("\n\n\t 3 - Inicialização de Vetor Strings");
            Console.Write("\n\n\t 4 - Inicialização e Leitura de Vetor com FOREACH");
            Console.Write("\n\n\t 5 - Vetor de Inteiros e Strings (Aluno / Nota)");
            Console.Write("\n\n\t 6 - Números Pares e Ímpares");
            Console.Write("\n\n\t 7 - Teste 2 Listas");

            Console.Write("\n\n\t 0 - Sair");
            Console.Write("\n\n\t**********************************************");
        }
        static void opcao1()
        {
            Console.Clear();
            Console.Write("\n\n\t********** Exercícios com Vetores ************");
            Console.Write("\n\n\t Opcão Selecionada - 1\n");

            int[] valores = new int[5] { 10, 20, 30, 40, 50 };
            Console.WriteLine("\n\tValor na posição 2 = {0}", valores[1]);
            Console.WriteLine("\n\tValor na posição 3 = {0}", valores[2]);
            Console.WriteLine("\n\tValor na posição 4 = {0}", valores[3]);

            Console.ReadKey();
        }
        static void opcao2()
        {
            Console.Clear();
            Console.Write("\n\n\t********** Exercícios com Vetores ************");
            Console.Write("\n\n\t Opcão Selecionada - 2");
            int[] valores1 = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            Console.Write("\n\n\t Indica a posição que pretende visualizar: ");
            int posicao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\tO valor na posição {0} é {1}!", posicao, valores1[posicao - 1]);
            Console.ReadKey();

        }
        static void opcao3()
        {
            Console.Clear();
            Console.Write("\n\n\t********** Exercícios com Vetores ************");
            Console.Write("\n\n\t Opcão Selecionada - 3\n\n");

            string[] cidades = { "Alcobaça", "Viana do Castelo", "Estremoz" };

            for (int i = 0; i < cidades.Length; i++)
            {
                Console.WriteLine("\n\tCidade na posição {0} - {1}", i + 1, cidades[i]);
            }

            Console.ReadKey();

        }
        static void opcao4()
        {
            Console.Clear();
            Console.Write("\n\n\t********** Exercícios com Vetores **********");
            Console.Write("\n\n\t Opcão Selecionada - 4\n");

            int[] temperaturas = { 19, 32, -4 };

            foreach (int ind in temperaturas)
            {
                Console.WriteLine("\n\tTemperatura - {0} ", ind);
            }

            Console.ReadKey();
        }
        static void opcao5()
        {
            Console.Clear();
            Console.Write("\n\n\t********** Exercícios com Vetores **********");
            Console.Write("\n\n\t Opcão Selecionada - 5");

            double soma = 0;
            int[] notasTeste = new int[5];
            string[] nomesAl = new string[5];

            for (int i = 0; i < nomesAl.Length; i++)
            {
                Console.Write("\n\tNome do aluno: ");
                nomesAl[i] = Convert.ToString(Console.ReadLine());

                Console.Write("\tNota Obtida: ");
                notasTeste[i] = Convert.ToInt32(Console.ReadLine());
                soma = soma + notasTeste[i];
    }

    static void opcao1() 
    {
        Console.Clear();
        Console.WriteLine("\n\n\t")
    }
}
