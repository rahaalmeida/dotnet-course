using System.Globalization;

namespace ExercicioContaBancaria
{
    class Conta
    {
        public int Numero { get; private set; }
        public double Saldo { get; private set; }
        public string Titular { get; set; }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numeroDaConta, string nomeTitular, double valorDeposito) : this(numeroDaConta, nomeTitular)
        {
            Deposito(valorDeposito);
        }

        public void Deposito(double valorDepositado)
        {
            Saldo += valorDepositado;
        }

        public void Saque(double valorSaque)
        {
            Saldo -= valorSaque + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                    + Numero
                    + ", Titular: "
                    + Titular
                    + ", Saldo: $ "
                    + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
