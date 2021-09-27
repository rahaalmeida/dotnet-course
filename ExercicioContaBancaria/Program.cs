using System;
using System.Globalization;

namespace ExercicioContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.Write("Entre com o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char opcao = char.Parse(Console.ReadLine());

            if(opcao == 's' || opcao == 'S')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numConta, nome, valorInicial);
            }
            else
            {
                conta = new Conta(numConta, nome);
            }

            Console.WriteLine("Dados da conta: " + conta.ToString());

            Console.Write("Entre com um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valorDeposito);
            Console.WriteLine("Dados da conta atualizados: " + conta.ToString());

            Console.Write("Entre com um valor para saque: ");
            double valorDoSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valorDoSaque);
            Console.WriteLine("Dados da conta atualizados: " + conta.ToString());

            Console.ReadLine();
        }
    }
}
