using System;

class Program
{
    static void Main()
    {
        double valorPresente;
        double taxaJuros;
        int periodoAnos;

        Console.WriteLine("Digite o valor presente: ");
        valorPresente = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a taxa de juros: ");
        taxaJuros = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o período de anos: ");
        periodoAnos = int.Parse(Console.ReadLine());

        taxaJuros = taxaJuros / 100;
        double rendimento = valorPresente * Math.Pow((1 + taxaJuros), periodoAnos);

        Console.WriteLine("Rendimento = " + rendimento.ToString("C2"));


    }
}
