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
        public class Exercicio8
        {
            public static void Executar()
            {
                Console.Write("Digite a quantidade de linhas: ");
                int x = int.Parse(Console.ReadLine());

                string escada = "";

                for (int i = 1; i <= x; i++)
                {
                    escada += "*";
                    Console.WriteLine(escada);
                }
            }
        }
    }
}
