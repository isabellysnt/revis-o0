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
        public class Exercicio18
        {
            public static void Executar()
            {
                double[] precos = { 10.0, 25.5, 30.0, 42.9, 15.75 };

                foreach (double preco in precos)
                {
                    double novoPreco = preco * 1.10;
                    Console.WriteLine("Preço com aumento: " + novoPreco);
                }
            }
        }
    }
}
