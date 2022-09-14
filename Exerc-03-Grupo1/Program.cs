using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_03_Grupo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("\tEscolha 3 números inteiros para serem apresentados a soma e multiplicaçºao dos mesmos");

            Console.Write("\n\tDigite o primeiro valor inteiro:   ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\n\tDigite o segundo valor inteiro:   ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("\n\tDigite o terceiro valor inteiro:   ");
            num3 = int.Parse(Console.ReadLine());

            int soma = num1 + num2 + num3;
            int produto = num1 * num2 * num3;

            Console.WriteLine($"\n\tA soma dos três números é: {soma}");
            Console.WriteLine($"\n\tO produto dos três números é: {produto}");

        }
    }
}
