using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continuação
{
    using System;
    using System.Collections.Generic;

    namespace AtividadeRevisao
    {
        public class Exercicio16
        {
            public static void Executar()
            {
                List<int> numeros = new List<int> { -5, 10, -3, 8, 0, 15, -1 };

                Console.WriteLine("Números positivos:");

                foreach (int numero in numeros)
                {
                    if (numero > 0)
                    {
                        Console.WriteLine(numero);
                    }
                }
            }
        }
    }
}
