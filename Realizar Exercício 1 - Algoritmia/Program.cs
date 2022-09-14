using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Realizar_Exercício_1___Algoritmia
{
    internal class Program
    {

        //Escreva um programa que peça dois valores ao utilizador e apresente o resultado das quatro operações aritméticas básicas (+, -, * e /).
        static void Main(string[] args)
        {
            float num1, num2;

            Console.Write("\n\tDigite o primeiro valor:   ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("\n\tDigite o segundo valor:   ");
            num2 = float.Parse(Console.ReadLine());

            float soma = num1 + num2;
            float subtracao = num1 - num2;
            float quociente = num1 / num2;
            float produto = num1 * num2;

            Console.WriteLine($"\n\tA soma = {soma}");
            Console.WriteLine($"\n\tA subtração = {subtracao}");
            Console.WriteLine($"\n\tO quociente = {quociente}");
            Console.WriteLine($"\n\tO produto = {produto}");
        }
    }
}