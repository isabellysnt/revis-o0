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
        public class Exercicio20
        {
            public static void Executar()
            {
                int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                Console.WriteLine("Números pares:");
                foreach (int numero in numeros)
                {
                    if (numero % 2 == 0)
                    {
                        Console.WriteLine(numero);
                    }
                }

                Console.WriteLine("Números ímpares:");
                foreach (int numero in numeros)
                {
                    if (numero % 2 != 0)
                    {
                        Console.WriteLine(numero);
                    }
                }
            }
        }
    }
}
