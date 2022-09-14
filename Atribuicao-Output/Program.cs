using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atribuicao_Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1;                     //Define variável valor1 do tipo inteiro
            int valor2 = 10;                //Define variável valor2 e atribui-lhe o valor 10
                            
            valor1 = 20;                    //Atribui o valor 20 à variável int

            //Calcular a soma de valor1 com valor2
            int soma = valor1 + valor2;

            //Apresentar o resultado de soma
            Console.WriteLine(soma);                              //APrensenta apenas o resultado

            Console.WriteLine("\n\t O resultado da soma é " + soma);   //Apresenta a soma com concatenação
            // \n abre uma nova linha(ENTER) e o \t (TAB)

            Console.WriteLine("Oresultado da soma é {0}", soma);  //com indice das variáveis

            Console.WriteLine("{0} + {1} = {2}", valor1, valor2, soma);

            Console.WriteLine($"\n\t{valor1} + {valor2} = {soma}");


        }
    }
}
