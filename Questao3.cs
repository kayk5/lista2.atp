using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    public static class Questão3
    {
        public static void Executar()
        {
            double a, b, x;

            Console.Write("Digite o coeficiente 'a' da equação: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o coeficiente 'b' da equação: ");
            b = double.Parse(Console.ReadLine());

            x = -b / a;

            Console.WriteLine("A raiz da equação é: " + x);
        }
    }
}
    

