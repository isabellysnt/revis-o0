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
        public class Exercicio19
        {
            public static void Executar()
            {
                List<string> frutas = new List<string> { "maçã", "banana", "uva", "laranja", "manga" };

                Console.Write("Digite o nome de uma fruta: ");
                string frutaDigitada = Console.ReadLine().ToLower();

                bool encontrou = false;

                foreach (string fruta in frutas)
                {
                    if (fruta.ToLower() == frutaDigitada)
                    {
                        encontrou = true;
                        break;
                    }
                }

                if (encontrou)
                {
                    Console.WriteLine("A fruta está na lista.");
                }
                else
                {
                    Console.WriteLine("A fruta não está na lista.");
                }
            }
        }
    }
}
