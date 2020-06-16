using System;



    class Program
    {
        static void Main(string[] args)
        {
            Jogador x = new Jogador();
            x.Nome= "Neymar";
            x.Altura = 1.80f;
            x.Peso = 80f;
            x.Nascimento = DateTime.Parse("27/07/1991");
            x.Posicao = "Atacante";
            
            Console.WriteLine(x.CalcularIdade());
            Console.WriteLine(x.VerificarAposentadoria());
        }
    }

