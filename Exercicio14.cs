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
        public class Exercicio14
        {
            public static void Executar()
            {
                double[] numeros = { 5.5, 8.2, 3.1, 10.7, 6.4 };
                double maior = numeros[0];

                foreach (double numero in numeros)
                {
                    if (numero > maior)
                    {
                        maior = numero;
                    }
                }

                Console.WriteLine("Maior valor = " + maior);
            }
        }
    }
}
