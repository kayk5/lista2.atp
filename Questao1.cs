using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    public static class Questao1
    {
        public static void Executar()
        {
            // Declarando as varíaveis
            int x, y;

            // Leitura dos valores
            Console.WriteLine("Digite o primeiro número:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            y = int.Parse(Console.ReadLine());

            // Verificando o maior número
            if (x > y)
            {
                Console.WriteLine("O maior número é: " + x);
            }
            else
            {
                Console.WriteLine("O maior número é: " + y);
            }

        }

    }

}
        
    
