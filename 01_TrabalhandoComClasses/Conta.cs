using System;
namespace ContasBancarias
{
    public class Conta
    {
        // adicionando atributos na classe
        public string Numero;
        public DateTime DataAbertura;
        public decimal Saldo;
        // metodos com retorno
        public string ExibirExtrato()
        {
            return $"Conta Nº: {Numero}{Environment.NewLine} "
            + $"Data Abertura         {DataAbertura}{Environment.NewLine}"
             + $"Saldo da conta        {Saldo.ToString("c")}{Environment.NewLine}"
             + "--------------------------------------";
        }
        // adiconanando metodos a classe
        // metodo sem retorno 
        /*public void ExibirExtrato()
        {
            Console.WriteLine($"Conta Nº:             {Numero}");
            Console.WriteLine($"Data Abertura         {DataAbertura}");
            Console.WriteLine($"Saldo da conta        {Saldo.ToString("c")}");
        }
*/
        // metodos com parametros
        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }
        public void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        // metodos com sobrecarga

        public void RealizarEmprestimo(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine("O valor será debitado da conta no mes seguinte.");
        }
        public void RealizarEmprestimo(decimal valor, int parcelas)
        {
            Saldo += valor;
            Console.WriteLine("O valor será debitado da conta em 10 parcelas");
        }

        // propriedades estaticas
        public static double TaxaRendimento = 0.05f;

        // metodos estaticos
        public static double CalcularRendimento(double capital, int meses)
        {
            return capital * Math.Pow(1 + TaxaRendimento, meses);
        }
    }





}


