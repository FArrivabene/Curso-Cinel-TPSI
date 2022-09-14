using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{   

    //18.Escreva um programa que peça dois números ao utilizador e indique qual é o maior.
    internal class Program
    {
        static void Main(string[] args)
        {
            float valor1, valor2;

            Console.Write("Digite o primeiro valor:  ");
            valor1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor:   ");
            valor2 = int.Parse(Console.ReadLine());

            if (valor1 > valor2)
            {
                Console.WriteLine($"\n\tO primeiro número é maior");
            }
            else if (valor1 < valor2)
            {
                Console.WriteLine($"\n\tO segundo número é maior");
            }
            else
            {
                Console.WriteLine($"\n\tOs números são iguais!");
            }


        }
    }
}
