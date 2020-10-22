using System;
using System.Collections.Generic;
using System.Text;

namespace APLICATIVOS
{
    public class Porta
    {
        public bool Aberta { get; set; }
        public string Cor { get; set; }
        public float Altura { get; set; }
        public float Largura { get; set; }

        public Porta()
        {

        }

        public void Abrir()
        {
            this.Aberta = true;
        }
        public void Fechar()
        {
            this.Aberta = false;
        }
        public void Pintar(string cor)
        {
            this.Cor = cor;
        }
        public bool estaAberta()
        {
            return this.Aberta == true;
        }
        public void setAltura(float altura)
        {
            this.Altura = altura;
        }
        public void setLargura(float largura)
        {
            this.Largura = largura;
        }

        
    }
}
