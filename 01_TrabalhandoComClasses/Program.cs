// See https://aka.ms/new-console-template for more information
using System;

namespace TrabalhandoComClasses
{
    // criando uma classe

    class Program
    {
        // instanciação e criação do objeto

        static void Main(string[] args)
        {
            var conta1 = new Conta();
            Console.WriteLine("Informe a Data de Abertura: ");
            conta1.DataAbertura = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Informe o número da conta: ");
            conta1.Numero = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Informe o saldo da conta: ");
            conta1.Saldo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A Data  de abertura  conta é : {conta1.DataAbertura}");
            Console.WriteLine($"Numero da sua conta é : {conta1.Numero}");
            Console.WriteLine($"o saldo da sua conta é : {conta1.Saldo}");

        }
    }
}
