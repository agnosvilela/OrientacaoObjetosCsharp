using System;

namespace blocoTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var nomes = new[] { "Agnos", "Suelen" };
                for (var i = 0; i <= nomes.Length; i++)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
            catch (Exception tipoErro)
            {
                Console.WriteLine("Ocorreu um erro" + tipoErro.Message);


            }
        }
    }
/*Erro do da compilação do código.
Unhandled exception. System.IndexOutOfRangeException:
 Index was outside the bounds of the array.*/