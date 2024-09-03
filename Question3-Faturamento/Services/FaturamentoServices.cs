using Question3_Faturamento.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Question3_Faturamento.Services
{
    internal class FaturamentoServices : IFaturamentoServices
    {
        public decimal GetSmaller(FaturamentoDiario[] faturamentosDiarios)
        {
            var day = faturamentosDiarios
                .Where(x => x.valor != 0)
                .MinBy(x => x.valor);
            return day.valor;
        }

        public decimal GetBigger(FaturamentoDiario[] faturamentosDiarios)
        {
            var day = faturamentosDiarios.MaxBy(x => x.valor);
            return day.valor;
        }

        public decimal GetAverage(FaturamentoDiario[] faturamentosDiarios)
        {
            return faturamentosDiarios
                .Where(x => x.valor != 0)
                .Average(x => x.valor);
        }

        public int GetDaysAboveAverage(FaturamentoDiario[] faturamentosDiarios)
        {
            decimal average = GetAverage(faturamentosDiarios);
            return faturamentosDiarios.Where(x => x.valor > average).Count();
        }
    }
}
