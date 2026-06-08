using System;

class Program
{
    static void Main()
 
    {
        double valorPresente;
        double valorFuturo;
        double taxaJuros;
        int periodoAnos;



        Console.Write("Digite o valor futuro: ");
        valorFuturo = double.Parse(Console.ReadLine());

        Console.Write("Digite a taxa de juros: ");
        taxaJuros = double.Parse(Console.ReadLine());

        Console.Write("Qual o periodo de anos?: ");
        periodoAnos = int.Parse(Console.ReadLine());

        valorPresente = valorFuturo / Math.Pow((taxaJuros + 1), periodoAnos);

        Console.WriteLine("O valor presente é: " + valorPresente.ToString("C2"));


    }

}
