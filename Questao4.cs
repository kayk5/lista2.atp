using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    public static class Questão4
    {
        public static void Executar()
        {
            int anoNascimento, anoAtual, idade;
            char fezAniversario;

            Console.Write("Digite o ano de nascimento: ");
            anoNascimento = int.Parse(Console.ReadLine());

            Console.Write("Já fez aniversário este ano? (S/N): ");
            fezAniversario = char.Parse(Console.ReadLine().ToUpper());

            anoAtual = DateTime.Now.Year;

            idade = anoAtual - anoNascimento;

            if (fezAniversario == 'N')
            {
                idade--;
            }

            Console.WriteLine("Sua idade é: " + idade);

            if (idade >= 18)
            {
                Console.WriteLine("Você já tem idade para conseguir a Carteira de Habilitação!");
            }
            else
            {
                Console.WriteLine("Você ainda não tem idade para conseguir a Carteira de Habilitação.");
            }
        }
    }
}
    

