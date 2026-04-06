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
        public class Exercicio3
        {
            public static void Executar()
            {
                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());

                for (int i = numero; i >= 0; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
