using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_12_Grupo01
{
    //05.Escreva  um  algoritmo  para  ler  as  dimensões  de  um  retângulo  (comprimento e largura) e calcular e escrever a área e o perímetro do retângulo.
    //Calcule também a área e o perímetro de uma circunferência.
    //Fórmulas
    //Área = comprimento x largura;
    //Perímetro= 2 x (comprimento + largura)

    //Fórmulas Circunferência:
    //Área = PI x R^2
    //Perímetro = 2 x PI x R
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tVamos calcular a área e o perímetro do retângulo!");

            double comprimento, largura, raio;
            double areaR, periR, areaC, periC;

            Console.Write("\n\tDigite o comprimento do retângulo:   ");
            comprimento = double.Parse(Console.ReadLine());
            Console.Write("\n\tDigite a largura do retângulo:   ");
            largura = double.Parse(Console.ReadLine());

            areaR = comprimento * largura;
            periR = 2 * (comprimento + largura);

            Console.WriteLine($"\n\tA área do retângulo é de {areaR} metros quadrados");
            Console.WriteLine($"\n\tO perímetro do retângulo é de {periR} metros");

            Console.WriteLine("\n\tVamos calcular a área e o perímetro da circunferência!");

            Console.Write("\n\tDigite o raio da circunferência:   ");
            raio = double.Parse(Console.ReadLine());

            areaC = Math.PI * Math.Pow(raio, 2);
            periC = 2 * Math.PI * raio;

            Console.WriteLine($"\n\tA área da circunferência é de {areaC:0.00} metros quadrados");
            Console.WriteLine($"\n\tO perímetro da circunferência é de {periC:0.00} metros");

            Console.ReadKey();
        }
    }
}
