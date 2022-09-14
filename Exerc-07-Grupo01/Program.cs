using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_07_Grupo01
{
    internal class Program
    {   //7.Escrevaum programaque  leia  2  valores  inteiros  para duas  variáveis  e
        //no  final  do processamento as variáveis tenham os valores trocados.
        static void Main(string[] args)
        {
            int num1, num2, aux;

            Console.Write("\n\tDigite o primeiro valor:   ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\n\tDigite o segundo valor:   ");
            num2 = int.Parse(Console.ReadLine());

            //Troca dos valores das variáveis.
            aux = num1;
            num1 = num2;
            num2 = aux;

            Console.WriteLine($"\n\tnum1 = {num1} \n\tnum2 = {num2}");

            Console.ReadKey();

        }
    }
}
