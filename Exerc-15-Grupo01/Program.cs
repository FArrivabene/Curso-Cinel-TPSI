using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_15_Grupo01
{
    internal class Program
    {

        //A “Frutaria da Esquina” vende uma certa quantidade de bananas e maçãs por dia. Cada quilo de bananas custa 1,20 € e cada quilo de
        //maçãs custa 1,50 €. No final do dia, o  dono  quer  saber  quanto  faturou  com  a  vendas  das  bananas  e  das  maçãs  e
        //quanto deve guardar numa conta de poupança (10% do total faturado).
        //Elabore um programa para ler a quantidade de fruta vendida e calcular os dados solicitados.
        static void Main(string[] args)
        {
            double banana, maca;

            Console.Write("\n\tQuantos quilos de bananas foram vendidos?:   ");
            banana = 1.2 * float.Parse(Console.ReadLine());
            Console.Write("\n\tQuantos quilos de maçãs foram vendidos?:   ");
            maca = 1.5 * float.Parse(Console.ReadLine());

            double vendas;
                vendas = banana + maca;

            Console.WriteLine($"\n\tForam vendidos o total de {vendas} euros em bananas e maçãs.");

            double guardar;
            guardar = vendas * 0.1;

            Console.WriteLine($"\n\tDeverá guardar {guardar} euros em sua conta.");

        }
    }
}
