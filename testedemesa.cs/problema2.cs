using System;

class Program
{
    static void Main()
    {
        decimal valorPresente = 3800m;
        decimal taxaJuros = 1.25m / 100;
        int periodoMes = 6;

        double rendaAcumulada = (double)valorPresente;

        for (int i = 0; i <= periodoMes; i++)

        {
            double rendimento =
                (double)valorPresente * Math.Pow((double)(1 + taxaJuros), i);

            double rendimentoLiquido = rendimento - (double)valorPresente;

            rendaAcumulada += rendimentoLiquido;

            Console.WriteLine("Mês: " + i);
            Console.WriteLine("Rendimento: " + rendimento.ToString("C2"));
            Console.WriteLine("Rendimento Líquido: " + rendimentoLiquido.ToString("C2"));
            Console.WriteLine("Renda Acumulada: " + rendaAcumulada.ToString("C2"));
           


        }











    }


}
