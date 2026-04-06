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
        public class Exercicio1
        {
            public static void Executar()
            {
                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(numero + " x " + i + " = " + (numero * i));
                }
            }
        }
    }
}
