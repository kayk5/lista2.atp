using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    public static class Questão2
    {
        public static void Executar()
        {
            int num1, num2, soma;

            Console.Write("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;

            if (soma >= 10)
            {
                soma += 5;
            }
            else
            {
                soma += 7;
            }

            Console.WriteLine("O resultado final é: " + soma);
        }
    }
}







