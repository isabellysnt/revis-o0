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
        public class Exercicio15
        {
            public static void Executar()
            {
                Console.Write("Digite uma frase: ");
                string frase = Console.ReadLine();

                int contador = 0;

                foreach (char letra in frase)
                {
                    if (letra == 'a' || letra == 'A')
                    {
                        contador++;
                    }
                }

                Console.WriteLine("Quantidade de letras 'a': " + contador);
            }
        }
    }
}
