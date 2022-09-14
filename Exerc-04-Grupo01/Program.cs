using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_04_Grupo01
{
    internal class Program
    {

        //04.Calcule  o  IMC  (Índice  de  Massa  Corporal)  de  uma  pessoa  tendo
        //como  dados  de entrada o seu peso em Kg e a sua altura em metros.
        //O cálculo é obtido dividindo o peso da pessoa pelo quadrado da sua altura.
        static void Main(string[] args)
        {
            Console.WriteLine("\nDigite o seu peso em Kg e sua altura em metros para calcularmos o seu IMC");

            float peso, altura;

            Console.Write("\n\tDigite seu peso em kg:   ");
            peso = float.Parse(Console.ReadLine());
            Console.Write("\n\tDigite sua altura em metros:   ");
            altura = float.Parse(Console.ReadLine());

            //float imc = peso / (altura * altura);
            float imc = (float)(peso / Math.Pow(altura, 2));    //cast explicito de double para float

            Console.WriteLine($"\n\tO seu IMC é {imc}");
            Console.WriteLine($"\n\tO seu IMC é {imc:0.00}"); //fomata o valor na saída para tantos zeros após o ponto.
            Console.WriteLine($"\n\tO seu IMC é {Math.Round(imc, 1)}");

            Console.ReadKey();
        }
    }
}
