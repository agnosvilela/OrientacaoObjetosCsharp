using System;
namespace ContasBancarias
{
    public class Conta
    {
        // adicionando atributos na classe
        public string Numero;
        public DateTime DataAbertura;
        public decimal Saldo;

        // adiconanando metodos a classe
        public void ExibirExtrato()
        {
            Console.WriteLine($"Conta Nº:             {Numero}");
            Console.WriteLine($"Data Abertura         {DataAbertura}");
            Console.WriteLine($"Saldo da conta        {Saldo.ToString("c")}");
        }
    }


}


