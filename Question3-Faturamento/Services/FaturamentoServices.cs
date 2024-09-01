using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Question3_Faturamento.Services
{
    internal class FaturamentoServices
    {
        public static decimal GetSmaller(decimal[] faturamento)
        {
            decimal[] faturamentoTemp = faturamento;
            Array.Sort(faturamentoTemp);
            foreach (decimal value in  faturamentoTemp)
            {
                if(value != 0)
                {
                    return value;
                }
            }
            return 0;
        }

        public static decimal GetBigger(decimal[] faturamento)
        {
            decimal[] faturamentoTemp = faturamento;
            Array.Sort(faturamentoTemp);
            return faturamentoTemp[faturamentoTemp.Length - 1];
        }

        public static decimal GetAverage(decimal[] faturamento)
        {
            decimal totalValue = 0;
            int daysOn = 0;
            foreach(decimal value in faturamento)
            {
                if(value != 0)
                {
                    totalValue += value;
                    daysOn++;
                }
            }
            return totalValue/daysOn;
        }

        public static int GetDaysAboveAverage(decimal[] faturamento)
        {
            decimal average = GetAverage(faturamento);
            int daysAbove = 0;
            
            foreach(decimal value in faturamento)
            {
                if (value > average)
                {
                    daysAbove++;
                }
            }
            return daysAbove;
        }
    }
}
