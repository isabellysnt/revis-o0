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
        public class Exercicio13
        {
            public static void Executar()
            {
                int[] numeros = { 10, 20, 30, 40, 50 };
                int soma = 0;

                foreach (int numero in numeros)
                {
                    soma += numero;
                }

                Console.WriteLine("Soma = " + soma);
            }
        }
    }
}
