using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continuação
{
    using System;

    namespace AtividadeRevisao
    {
        public class Exercicio6
        {
            public static void Executar()
            {
                Console.Write("Quantas notas deseja digitar? ");
                int quantidade = int.Parse(Console.ReadLine());

                double soma = 0;

                for (int i = 1; i <= quantidade; i++)
                {
                    Console.Write("Digite a nota " + i + ": ");
                    double nota = double.Parse(Console.ReadLine());
                    soma += nota;
                }

                double media = soma / quantidade;
                Console.WriteLine("Média = " + media);
            }
        }
    }
}
