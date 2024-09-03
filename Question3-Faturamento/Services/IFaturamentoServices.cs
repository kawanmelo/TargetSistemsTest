using Question3_Faturamento.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3_Faturamento.Services
{
    internal interface IFaturamentoServices
    {
        public decimal GetSmaller(FaturamentoDiario[] faturamentosDiarios);

        public decimal GetBigger(FaturamentoDiario[] faturamentosDiarios);

        public decimal GetAverage(FaturamentoDiario[] faturamentosDiarios);

        public int GetDaysAboveAverage(FaturamentoDiario[] faturamentosDiarios);
    }
}
