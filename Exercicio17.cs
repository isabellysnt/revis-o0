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
        public class Exercicio17
        {
            public static void Executar()
            {
                Console.Write("Digite uma palavra: ");
                string palavra = Console.ReadLine();

                for (int i = palavra.Length - 1; i >= 0; i--)
                {
                    Console.Write(palavra[i]);
                }

                Console.WriteLine();
            }
        }
    }
}
