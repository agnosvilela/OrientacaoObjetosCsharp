// See https://aka.ms/new-console-template for more information
using System;

namespace TrabalhandoComClasses
{
    // criando uma classe
    class Aluno
    {
        // adicionando as propriedades na classe
        public string Nome;
        public int idade;
    }
    class Program
    {
        // instanciação e criação do objeto

        static void Main(string[] args)
        {
            var aluno1 = new Aluno();
            aluno1.Nome = "Agnos vilela";
            aluno1.idade = 32;

            Console.WriteLine(aluno1.Nome);
            Console.WriteLine(aluno1.idade + " " + "Anos de idade.");
        }
    }
}
