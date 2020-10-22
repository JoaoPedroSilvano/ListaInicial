using System;
using System.Collections.Generic;
using System.Text;

namespace APLICATIVOS
{
    public class Casa
    {
        public Porta Porta1 { get; set; }
        public Porta Porta2 { get; set; }
        public Porta Porta3 { get; set; }
        public string CorCasa { get; set; }
        public Casa()
        {
            Porta1 = new Porta();
            Porta2 = new Porta();
            Porta3 = new Porta();
        }

        public void Pintar (string CorCasa)
        {
            this.CorCasa = CorCasa;
        }
        public int QuantasPortasEstaoAberta()
        {
            int PortasAbertas = 0;

            if (Porta1.estaAberta() == true)
            {
                PortasAbertas++;
            }
            if (Porta2.estaAberta() == true)
            {
                PortasAbertas++;
            }
            if (Porta3.estaAberta() == true)
            {
                PortasAbertas++;
            }

            return PortasAbertas;
        }
    }
}
