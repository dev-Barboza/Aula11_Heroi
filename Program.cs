using System;

namespace PolimorfismoII_Senai
{
    class Program
    {
        static void Main(string[] args)
        {
           Calculo infoPlayer = new Calculo();
            //primeira opçao sem argumento 
            System.Console.WriteLine(infoPlayer.Calcular());

            //segunda opcao 
            System.Console.WriteLine(infoPlayer.Calcular(100));

            //terceira opçao

            System.Console.WriteLine(infoPlayer.Calcular(100,1000));

            //quarta opçao

            System.Console.WriteLine(infoPlayer.Calcular("Tony", "Stark"));

            System.Console.WriteLine(infoPlayer.Calcular( "Homem de ferro"));
        }
    }
}
