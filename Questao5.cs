using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    public static class Questão5
    {
        public static void Executar()
        {
            double nota;

            Console.Write("Digite a nota: ");
            nota = double.Parse(Console.ReadLine());

            if (nota >= 8 && nota <= 10)
            {
                Console.WriteLine("Ótimo");
            }
            else if (nota >= 7 && nota < 8)
            {
                Console.WriteLine("Bom");
            }
            else if (nota >= 5 && nota < 7)
            {
                Console.WriteLine("Regular");
            }
            else if (nota < 5)
            {
                Console.WriteLine("Insatisfatório");
            }
            else
            {
                Console.WriteLine("Nota inválida!");
            }
        }
    }
}
    

