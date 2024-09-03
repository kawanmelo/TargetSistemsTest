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
            var jsonString = File.ReadAllText("C:\\Users\\Kawan Melo\\source\\repos\\TargetSistemsTest\\Question3-Faturamento\\dados.json");
            FaturamentoDiario[] vetorFaturamentos = JsonSerializer.Deserialize<FaturamentoDiario[]>(jsonString);

            IFaturamentoServices faturamentoServices = new FaturamentoServices();

            Console.WriteLine($"Média do faturamento mensal : {faturamentoServices.GetAverage(vetorFaturamentos)}");
            Console.WriteLine($"Maior faturamento : {faturamentoServices.GetBigger(vetorFaturamentos)}");
            Console.WriteLine($"Menor faturamento : {faturamentoServices.GetSmaller(vetorFaturamentos)}");
            Console.WriteLine($"Dias em que o faturamento foi acima da média mensal : {faturamentoServices.GetDaysAboveAverage(vetorFaturamentos)} dias");
        }
    }
}
