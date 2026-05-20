using System;

class Program
{
    //valor presente = 1000
    //taxa de juros = 5,30% ao ano
    //periodo de meses = 6





    static void Main()
    {
        decimal valorPresente = 1000m; 
        decimal taxaJuros = 5.30m / 100;
        int periodoMeses = 6;

        double valorFuturo = (double)valorPresente * Math.Pow((double)(1 + taxaJuros), periodoMeses);

        Console.WriteLine(valorFuturo.ToString("F2"));

    }
}
