using System;
using System.Collections.Generic;
using System.Text;

namespace APLICATIVOS
{
    public static class MetodoCliente
    {
        public static void MeuClienteMinhaVida()
        {
            Cliente Cliente = new Cliente();
            Cliente.HorasTotais = 3;
            Cliente Cliente1 = new Cliente();
            Cliente1.HorasTotais = 4;

            Console.WriteLine(Cliente.CalcularTaxa());
        }
    }
}
