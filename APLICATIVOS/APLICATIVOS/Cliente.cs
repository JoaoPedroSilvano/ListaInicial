using System;
using System.Collections.Generic;
using System.Text;

namespace APLICATIVOS
{
    public class Cliente
    {
        public string NomeCliente { get; set; }
        public double HorasTotais { get; set; }
        public string CarroCliente { get; set; }

        public double CalcularTaxa()
        {
            double taxa;

            if (HorasTotais == 1)
            {
                taxa = HorasTotais * 5.00;

            }
            else
            {
                taxa = (HorasTotais - 1) * 3.00 + 5.00;

            }
            return taxa;
        }

        
    }
}
