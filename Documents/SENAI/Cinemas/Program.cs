using System;

namespace Cinemas
{
    class Program
    {
        static void Main(string[] args)
        {
           IngressoVip bilhete = new IngressoVip();
           System.Console.WriteLine("Ola! Bem vindo Ao cinema !");
           bilhete.ValorIngresso = 22f;
           bilhete.ValorVip = 12f;
           bilhete.ImprimirValor();
           bilhete.AdicionarValor();

           System.Console.WriteLine("A diferença de valor é R$ " + bilhete.ValorVip);
          
           
           
           
    }
 }
}
