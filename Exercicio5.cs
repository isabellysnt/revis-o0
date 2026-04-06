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
        public class Exercicio5
        {
            public static void Executar()
            {
                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());

                int fatorial = 1;

                for (int i = numero; i >= 1; i--)
                {
                    fatorial *= i;
                }

                Console.WriteLine("Fatorial = " + fatorial);
            }
        }
    }
}
