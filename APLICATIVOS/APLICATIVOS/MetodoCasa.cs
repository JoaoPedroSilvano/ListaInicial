using System;
using System.Collections.Generic;
using System.Text;

namespace APLICATIVOS
{
    public static class MetodoCasa
    {
        public static void MinhaCasaMinhaVida()
        {
            Porta porta = new Porta();

            porta.Fechar();
            porta.Abrir();
            porta.Pintar("A cor da porta é azul");
            Console.WriteLine(porta.Cor);
            porta.Pintar("agora a porta é preta");
            Console.WriteLine(porta.Cor);
            porta.Pintar("agora a porta é roxa");
            Console.WriteLine(porta.Cor);
            porta.Pintar("e por fim está pintada de laranja");
            Console.WriteLine(porta.Cor);
            porta.setLargura(3532);
            Console.WriteLine("A largura da porta é " + porta.Largura);
            porta.setAltura(3132);
            Console.WriteLine("a altura da porta é " + porta.Altura);
            if (porta.estaAberta() == true)
            {
                Console.WriteLine("A porta está aberta");
            }
            else
            {
                Console.WriteLine("A porta está fechada");
            }

            Casa Casa = new Casa();
            Casa.Porta1.Aberta = true;
            Casa.Porta2.Aberta = true;
            Casa.Porta3.Aberta = true;
            Casa.Porta1.Altura = 4233;
            Casa.Porta2.Altura = 2123;
            Casa.Porta3.Altura = 2003;
            Casa.Porta3.Altura = 2003;
            Casa.Porta1.Largura = 2003;
            Casa.Porta2.Largura = 2003;
            Casa.Porta3.Largura = 2003;
            Casa.Pintar("Azul");

            Console.WriteLine("Tem examente essa quantia total de portas abertas:" + Casa.QuantasPortasEstaoAberta());
            Console.WriteLine("a casa está pintada de " + Casa.CorCasa);

            Console.ReadKey();
        }
    }
}
