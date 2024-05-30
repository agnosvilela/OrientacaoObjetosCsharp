// See https://aka.ms/new-console-template for more information
using System;
using ContasBancarias;
namespace TrabalhandoComClasses
{
    // criando uma classe

    class Program
    {
        // instanciação e criação do objeto

        static void Main(string[] args)
        {
            var conta1 = new Conta();
            conta1.DataAbertura = DateTime.Now;
            Console.WriteLine("Informe o número da conta: ");
            conta1.Numero = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Informe o saldo da conta: ");
            conta1.Saldo = Convert.ToInt32(Console.ReadLine());

            conta1.ExibirExtrato();

        }
    }
}
