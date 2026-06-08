using System;

class Program
{
    static void Main()
    {
        double valorPresente;
        double taxaJuros;
        double resgate;
        double saldo;
        double rendimento;

        Console.Write("Digite o valor presente: ");
        valorPresente = double.Parse(Console.ReadLine());

        Console.Write("Digite a taxa de juros: ");
        taxaJuros = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor do resgate: ");
        resgate = double.Parse(Console.ReadLine());

        saldo = valorPresente;

        for (int mes = 0; mes <= 5; mes++)
        {
            Console.WriteLine("Mês: " + mes);

            if (mes == 0)
            {
                Console.WriteLine("Saldo: R$ " + saldo.ToString("F2"));
                Console.WriteLine("Rendimento: R$ 0,00");
                Console.WriteLine("Renda Líquida: R$ 0,00");
            }
            else
            {
                saldo = saldo * (1 + taxaJuros / 100);

                rendimento = saldo - valorPresente;

                Console.WriteLine("Saldo: R$ " + saldo.ToString("F2"));
                Console.WriteLine("Rendimento: R$ " + rendimento.ToString("F2"));
                Console.WriteLine("Renda Líquida: R$ " + rendimento.ToString("F2"));

                if (mes == 5)
                {
                    saldo = saldo - resgate;

                    Console.WriteLine("Resgate: R$ " + resgate.ToString("F2"));
                    Console.WriteLine("Saldo após resgate: R$ " + saldo.ToString("F2"));
                }
            }
        }
    }
}
