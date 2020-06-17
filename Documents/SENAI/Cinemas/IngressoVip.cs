using System;

class IngressoVip : Ingresso
{
    public float ValorVip { get; set; }

    public void AdicionarValor()
    {
        float newValor = ValorIngresso + ValorVip;
        System.Console.WriteLine(" O valor do ingresso VIP é " + newValor);
    }
}