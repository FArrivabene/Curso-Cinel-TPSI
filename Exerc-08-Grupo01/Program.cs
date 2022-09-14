using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_08_Grupo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 1, c = 3, d = 4;
            int res1, res2, res3, res4;

            //res1 = 3 * c * c * (9 - 5);
            res1 = 3 * (int)Math.Pow(c, 2) * (9 - 5); //cast explicito para int

            res2 = (2 * c + b * b) / (3 * d);

            res3 = 2 * b;

            res4 = 3 * a * c * (25+6);

            Console.WriteLine($"\n\tO resultado resposta1 = {res1}, \n\tresposta2 = {res2}, \n\tresposta3 = {res3}, \n\tresposta4 = {res4}");

            Console.ReadKey();
        }
    }
}
