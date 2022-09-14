using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício01
{
    internal class Program
    {
        /*Escreva umprograma que peça o nome e apelido e responmda com "Olá, nome apelido! Vamos começar a programar".
         * Peça também a idade da pessoa e apresente essa idade.
         */

        static void Main(string[] args)
        {
            string nome, apelido;       //define duas strings (cadeia de caracteres)

            Console.Write("\n\tDigite o seu nome:   ");
            nome = Console.ReadLine();          //ReadLine(); retorna uma string que vai ser atribuída à variável nome
            Console.Write("\n\tDigite o seu apelido:   ");
            apelido = Console.ReadLine();       //ReadLine(); retorna uma string que vai ser atribuída à variável apelido

            Console.WriteLine($"\n\tOlá {nome} {apelido}");

            Console.Write("\n\tDigite a sua idade:   ");
            int idade = int.Parse(Console.ReadLine());          //converte para inteiro a string retornada pelo ReadLine()
                                                                   //e atribui à variável idade, que é definida neste momento

            // int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n\t{nome} {apelido} tem {idade} anos");
        }
    }
}
