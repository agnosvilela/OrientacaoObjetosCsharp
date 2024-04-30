// Trabalhando com Classes em c#.
// criando nossa primeira classe.
using System;
namespace TrabalhandoComClasses
{


    class Aluno
    {
        public string Nome;
        public int Idade;
    }
    class program
    {
        static void Main(string[] args)
        {

            // instancia da classe é um objeto
            var aluno1 = new Aluno();
            aluno1.Nome = "Agnos Vilela";
            aluno1.Idade = 32;

            Console.WriteLine(aluno1.Nome);
            Console.WriteLine(aluno1.Idade);
        }
    }
}
