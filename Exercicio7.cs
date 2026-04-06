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
        public class Exercicio7
        {
            public static void Executar()
            {
                Console.Write("Digite a base: ");
                int baseNumero = int.Parse(Console.ReadLine());

                Console.Write("Digite o expoente: ");
                int expoente = int.Parse(Console.ReadLine());

                int resultado = 1;

                for (int i = 1; i <= expoente; i++)
                {
                    resultado *= baseNumero;
                }

                Console.WriteLine("Resultado = " + resultado);
            }
        }
    }
}
