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
        public class Exercicio10
        {
            public static void Executar()
            {
                int a = 0;
                int b = 1;

                Console.WriteLine("Os 15 primeiros números de Fibonacci são:");

                for (int i = 1; i <= 15; i++)
                {
                    Console.WriteLine(a);
                    int temp = a + b;
                    a = b;
                    b = temp;
                }
            }
        }
    }
}
