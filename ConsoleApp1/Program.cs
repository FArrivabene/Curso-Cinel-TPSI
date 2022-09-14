using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        //12.Escreva  um  programa  que  calcule  o  valor  do  imposto  a  pagar  sobre  um  produto,
        //sabendo que tem uma taxa de 40% sobre esse produto.
        static void Main(string[] args)
        {
            float imposto, produto;

            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("\n\tDigite o valor do produto:   ");
            produto = float.Parse(Console.ReadLine());
            imposto = produto * 0.4f;
            Console.WriteLine($"\n\tO valor do imposte é = {imposto:0.00}€");

            Console.ReadKey();
        }
    }
}
