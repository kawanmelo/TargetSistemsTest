using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, decimal> faturamentos = new Dictionary<string, decimal>
        {
            { "Sp", 67836.43M },
            { "Rj", 36678.66M },
            { "Mg", 29229.88M },
            { "Es", 27165.48M },
            { "Outros", 19849.53M }
        };

        decimal faturamentoTotal = 0;
        foreach (var valor in faturamentos.Values)
        {
            faturamentoTotal += valor;
        }

        Console.WriteLine("Percentual de representação de cada estado no faturamento total mensal:");
        foreach (var estado in faturamentos)
        {
            decimal percentual = (estado.Value / faturamentoTotal) * 100;
            Console.WriteLine($"{estado.Key}: {percentual:F2}%");
        }
    }
}
