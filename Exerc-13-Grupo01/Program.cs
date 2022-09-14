using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_13_Grupo01
{

    //13.Escreva um programa que converta o tempo de duração de um evento expresso em segundos e
    //mostre-o convertido em horas, minutos e segundos.
    internal class Program
    {
        static void Main(string[] args)
        {
            int segundos, h, m, s;
            int aux;

            Console.Write("\n\tDigite o evento em segundos:   ");
            segundos = int.Parse(Console.ReadLine());

            s = segundos % 60;
            aux = segundos / 60;
            m = aux % 60;
            h = aux / 60;

            Console.WriteLine($"\n\t{segundos} segundos = {h}h : {m}m : {s}s");
        }
    }
}
