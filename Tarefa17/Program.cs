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
        Console.WriteLine("\n\n\t************** Exercicios com vetores *************");
        Console.WriteLine("\n\n\t 1 - Iniciar vetor / Posiçao");
        Console.WriteLine("\n\n\t 2 - Visualizacao do valor na pos X");
        Console.WriteLine("\n\n\t 3 - Inicializacao de vetor strings");
        Console.WriteLine("\n\n\t 4 - Inicializacao e leitura de vetor com foreach");
        Console.WriteLine("\n\n\t 5 - Vetor inteiros e strings Aluno nota");
        Console.WriteLine("\n\n\t 6 - Numeros pares e impares");
        Console.WriteLine("\n\n\t 7 - Teste 2 Listas");
        Console.WriteLine("\n\n\t 0 - sair");
    }

    static void opcao1() 
    {
        Console.Clear();
        Console.WriteLine("\n\n\t")
    }
}
