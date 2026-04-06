using System;
using continuação.AtividadeRevisao;

namespace AtividadeRevisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== ATIVIDADE REVISÃO C# =====");
            Console.WriteLine("1 - Tabuada");
            Console.WriteLine("2 - Números Pares");
            Console.WriteLine("3 - Contagem Regressiva");
            Console.WriteLine("4 - Soma de Intervalo");
            Console.WriteLine("5 - Fatorial");
            Console.WriteLine("6 - Média de Notas");
            Console.WriteLine("7 - Potenciação");
            Console.WriteLine("8 - Desenho de Escada");
            Console.WriteLine("9 - Números Primos");
            Console.WriteLine("10 - Série de Fibonacci");
            Console.WriteLine("11 - Múltiplos de 3 e 5");
            Console.WriteLine("12 - Lista de Nomes");
            Console.WriteLine("13 - Soma de Array");
            Console.WriteLine("14 - Localizar Maior Valor");
            Console.WriteLine("15 - Contagem de Caracteres");
            Console.WriteLine("16 - Filtrar Negativos");
            Console.WriteLine("17 - Inversão de String");
            Console.WriteLine("18 - Lista de Preços");
            Console.WriteLine("19 - Verificar Item");
            Console.WriteLine("20 - Separador de Pares e Ímpares");
            Console.Write("Escolha um exercício: ");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Exercicio1.Executar();
                    break;
                case 2:
                    Exercicio2.Executar();
                    break;
                case 3:
                    Exercicio3.Executar();
                    break;
                case 4:
                    Exercicio4.Executar();
                    break;
                case 5:
                    Exercicio5.Executar();
                    break;
                case 6:
                    Exercicio6.Executar();
                    break;
                case 7:
                    Exercicio7.Executar();
                    break;
                case 8:
                    Exercicio8.Executar();
                    break;
                case 9:
                    Exercicio9.Executar();
                    break;
                case 10:
                    Exercicio10.Executar();
                    break;
                case 11:
                    Exercicio11.Executar();
                    break;
                case 12:
                    Exercicio12.Executar();
                    break;
                case 13:
                    Exercicio13.Executar();
                    break;
                case 14:
                    Exercicio14.Executar();
                    break;
                case 15:
                    Exercicio15.Executar();
                    break;
                case 16:
                    Exercicio16.Executar();
                    break;
                case 17:
                    Exercicio17.Executar();
                    break;
                case 18:
                    Exercicio18.Executar();
                    break;
                case 19:
                    Exercicio19.Executar();
                    break;
                case 20:
                    Exercicio20.Executar();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}