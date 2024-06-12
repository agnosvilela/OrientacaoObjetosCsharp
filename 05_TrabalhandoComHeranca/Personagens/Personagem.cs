using System;
namespace Personagens
{
    public class Personagem
    {
        public string Nome { get; set; }
        public string Vida { get; set; }
        public Personagem(string nome, string vida)
        {
            Nome = nome;
            Vida = vida;
        }
        public void Atacar()
        {
            Console.WriteLine($"{Nome} atacou");
        }
        public void Defender()
        {
            Console.WriteLine($"{Nome} Defendeu");
        }
    }
}