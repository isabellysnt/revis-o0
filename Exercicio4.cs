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
        public class Exercicio4
        {
            public static void Executar()
            {
                Console.Write("Digite o número inicial: ");
                int inicio = int.Parse(Console.ReadLine());

                Console.Write("Digite o número final: ");
                int fim = int.Parse(Console.ReadLine());

                int soma = 0;

                for (int i = inicio; i <= fim; i++)
                {
                    soma += i;
                }

                Console.WriteLine("Soma = " + soma);
            }
        }
    }
}
