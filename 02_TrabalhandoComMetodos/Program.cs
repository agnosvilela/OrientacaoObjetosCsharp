using System;
namespace TrabalhandoComMetodos
{

    class ContaCorrente
    {
        public string Numero;
        public decimal Saldo;
        // metodo sem retorno
        public void ImprimirInformacoes()
        {
            Console.WriteLine($"Numero {Numero} e o saldo é:  {Saldo}  ");
        }
        // metodo com retorno
        public string ListarInfo()
        {
            return $" {Numero} {Saldo}";
        }
        // metodo que recebe informaçoes nos parametros

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            var conta1 = new ContaCorrente();
            conta1.Numero = "001-002";
            conta1.Saldo = 0;
            //conta1.ImprimirInformacoes(); metodo sem retorno
            Console.WriteLine(conta1.ListarInfo()); // metodo com retorno
            conta1.Depositar(50);
            Console.WriteLine(conta1.ListarInfo());
        }

    }


}
