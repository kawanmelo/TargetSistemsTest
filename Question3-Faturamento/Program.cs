using System.Text.Json;
using System.IO;
using Question3_Faturamento.Entities;
using Question3_Faturamento.Services;

namespace Question3_Faturamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var jsonString = File.ReadAllText("C:\\Users\\Kawan Melo\\source\\repos\\TargetSistemsTest\\Question3-Faturamento\\faturamento.json");
            FaturamentoMensal faturamentoMensal = JsonSerializer.Deserialize<FaturamentoMensal>(jsonString);

            Console.WriteLine($"Média do faturamento mensal : {FaturamentoServices.GetAverage(faturamentoMensal.FaturamentosDiario)}");
            Console.WriteLine($"Maior faturamento : {FaturamentoServices.GetBigger(faturamentoMensal.FaturamentosDiario)}");
            Console.WriteLine($"Menor faturamento : {FaturamentoServices.GetSmaller(faturamentoMensal.FaturamentosDiario)}");
            Console.WriteLine($"Dias em que o faturamento foi acima da média mensal : {FaturamentoServices.GetDaysAboveAverage(faturamentoMensal.FaturamentosDiario)}");
        }
    }
}
